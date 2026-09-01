
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using projekat_2026.Data;
using projekat_2026.Data.Models;
using System;
using System.IO;
using System.Linq;

namespace projekat_2026.Core
{
    public class IzvestajService
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;
        private readonly string _templatePath;

        public IzvestajService(DbContextOptions<AppDbContext> dbOptions, string templatePath)
        {
            _dbOptions = dbOptions;
            _templatePath = templatePath;
        }



        public string GenerisiIzvestaj(int idPregledLog, string outputFolder)
        {
            using var db = new AppDbContext(_dbOptions);

            var pregled = db.PregledLogs
                .Include(p => p.IdFirmaObjekatNavigation)
                .Include(p => p.IdAgentNavigation)
                .Include(p => p.StavkaPregleda)
                    .ThenInclude(s => s.IdObjekatSistemVeznaTabelaNavigation)
                        .ThenInclude(o => o.IdSistemNavigation)
                .FirstOrDefault(p => p.IdPregledLog == idPregledLog);

            if (pregled == null)
                throw new Exception("Pregled nije pronađen.");

            string danas = DateTime.Now.ToString("ddMMyyHHmm");
            string kod = $"PP{pregled.IdFirmaObjekat}{pregled.IdPregledLog}{pregled.IdAgent}{danas}";
            string outputPath = Path.Combine(outputFolder, $"Izvestaj_{kod}.docx");

            File.Copy(_templatePath, outputPath, true);

            using (WordprocessingDocument doc = WordprocessingDocument.Open(outputPath, true))
            {
                var body = doc.MainDocumentPart?.Document?.Body;
                if (body == null)
                    throw new InvalidOperationException("Izabrani šablon nema validno telo dokumenta.");

                ReplacePlaceholder(body, "{{KOD}}", kod);
                ReplacePlaceholder(body, "{{DATUM}}", pregled.DatumPregleda.ToString("dd.MM.yyyy"));
                ReplacePlaceholder(body, "{{MESECGODINA}}", pregled.DatumPregleda.ToString("MM.yyyy"));
                ReplacePlaceholder(body, "{{FIRMA}}", pregled.IdFirmaObjekatNavigation?.ImeFirmeObjekat ?? "");
                ReplacePlaceholder(body, "{{ADRESA}}", $"{pregled.IdFirmaObjekatNavigation?.Adresa}, {pregled.IdFirmaObjekatNavigation?.Grad}");
                ReplacePlaceholder(body, "{{AGENT}}", pregled.IdAgentNavigation?.ImePrezime ?? "");
                ReplacePlaceholder(body, "{{NAPOMENA}}", pregled.Napomena ?? "Nema napomena.");

                var targetRow = body.Descendants<TableRow>()
                    .FirstOrDefault(r => r.InnerText.Contains("{{Stavka}}"));

                //NZM

                if (targetRow != null)
                {
                    var table = targetRow.Parent as Table;
                    if (table != null)
                    {
                        var stavke = pregled.StavkaPregleda.ToList();

                        foreach (var s in stavke)
                        {
                            var newRow = (TableRow)targetRow.CloneNode(true);

                            string naziv = s.IdObjekatSistemVeznaTabelaNavigation?.IdSistemNavigation?.Naziv ?? "";
                            string napomenaSist = s.IdObjekatSistemVeznaTabelaNavigation?.Napomena ?? "";
                            string status = s.Zadovoljava ? "Zadovoljava" : "Ne zadovoljava";
                            string napomenaStavke = s.NapomenaStavke ?? "";

                            ReplacePlaceholder(newRow, "{{Stavka}}", naziv);
                            ReplacePlaceholder(newRow, "{{NapomenaSistema}}", napomenaSist);
                            ReplacePlaceholder(newRow, "{{Status}}", status);
                            ReplacePlaceholder(newRow, "{{NapomenaStavke}}", napomenaStavke);

                            SetColumnWidths(newRow, new string[] { "3000", "2000", "1500", "2500" });

                            SetRowFontSize(newRow, "20");

                            table.AppendChild(newRow);
                        }

                        targetRow.Remove();
                    }
                }

                doc.MainDocumentPart?.Document?.Save();
            }

            return outputPath;
        }

        //JA OVO NEMOM POJMA KAKO RADI NE DIRAJ NISTA, DOK RADI... RADI

        private static void SetRowFontSize(TableRow row, string fontSizeInHalfPoints)
        {
            foreach (var run in row.Descendants<Run>())
            {
                run.RunProperties ??= new RunProperties();
                run.RunProperties.FontSize = new FontSize { Val = fontSizeInHalfPoints };
                run.RunProperties.FontSizeComplexScript = new FontSizeComplexScript { Val = fontSizeInHalfPoints };
            }
        }

        private static void SetColumnWidths(TableRow row, string[] widths)
        {
            var cells = row.Elements<TableCell>().ToList();
            for (int i = 0; i < cells.Count && i < widths.Length; i++)
            {
                var tcPr = cells[i].TableCellProperties;
                if (tcPr == null)
                {
                    tcPr = new TableCellProperties();
                    cells[i].AppendChild(tcPr);
                }

                tcPr.TableCellWidth = new TableCellWidth
                {
                    Type = TableWidthUnitValues.Dxa,
                    Width = widths[i]
                };
            }
        }

        private static void ReplacePlaceholder(OpenXmlElement element, string placeholder, string newValue)
        {
            foreach (var text in element.Descendants<Text>().Where(t => t.Text.Contains(placeholder)))
            {
                text.Text = text.Text.Replace(placeholder, newValue);
            }

            foreach (var paragraph in element.Descendants<Paragraph>().Where(p => p.InnerText.Contains(placeholder)))
            {
                string textContent = paragraph.InnerText.Replace(placeholder, newValue);

                var pPr = paragraph.ParagraphProperties?.CloneNode(true);
                paragraph.RemoveAllChildren();

                if (pPr != null)
                    paragraph.AppendChild(pPr);

                var newRun = new Run(new Text(textContent));
                paragraph.AppendChild(newRun);
            }
        }
    }
}





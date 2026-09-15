using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using projekat_2026.Data;
using projekat_2026.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace projekat_2026.Core
{
    public class IzvestajOpremaService
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;
        private readonly OpremaService opremaService;

        public IzvestajOpremaService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
            opremaService = new OpremaService(_dbOptions);
        }

        public string GenerisiIzvestajOpreme(int idFirmaObjekat, string outputFolder)
        {
            using var db = new AppDbContext(_dbOptions);

            var oprema = opremaService.GetByFirmaObjekatId(idFirmaObjekat);
            var firme = db.FirmaObjekats.FirstOrDefault(p => p.IdFirmaObjekat == idFirmaObjekat);

            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            string sirovoIme = firme?.ImeFirmeObjekat ?? "Firma";
            string bezbednoImeFirme = SanitizeFileName(sirovoIme);

            string datumUImenu = DateTime.Now.ToString("ddMMyyHHmmss");
            string fileName = $"Izvestaj_{bezbednoImeFirme}_{datumUImenu}.xlsx";
            string outputPath = Path.Combine(outputFolder, fileName);

            string datum = DateTime.Now.ToString("dd.MM.yyyy.");


            var colMaxLengths = new Dictionary<int, int>
            {
                { 1, 15 }, // Barkod
                { 2, 20 }, // Naziv opreme
                { 3, 20 }  // Napomena
            };

            using (var document = SpreadsheetDocument.Create(outputPath, SpreadsheetDocumentType.Workbook))
            {
                var workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();

                // Inicijalizacija Worksheeta
                var worksheet = new Worksheet();
                var sheetData = new SheetData();

                uint rowIndex = 1;

                AddRow(sheetData, ref rowIndex, "Komitent:", sirovoIme);
                AddRow(sheetData, ref rowIndex, "Datum:", datum);

                rowIndex++;
                AddRow(sheetData, ref rowIndex, "Barkod", "Naziv opreme", "Napomena");

                if (oprema == null || !oprema.Any())
                {
                    AddRow(sheetData, ref rowIndex, "Nema zabeležene opreme", "-", "-");
                }
                else
                {
                    foreach (var opremaStavka in oprema)
                    {
                        string barkod = opremaStavka.IdBarcode.ToString();
                        string naziv = opremaStavka.Naziv ?? "";
                        string napomena = opremaStavka.Napomena ?? "";

                        colMaxLengths[1] = Math.Max(colMaxLengths[1], barkod.Length);
                        colMaxLengths[2] = Math.Max(colMaxLengths[2], naziv.Length);
                        colMaxLengths[3] = Math.Max(colMaxLengths[3], napomena.Length);

                        AddRow(sheetData, ref rowIndex, barkod, naziv, napomena);
                    }
                }

                worksheet.Append(CreateColumns(colMaxLengths));
                worksheet.Append(sheetData);

                worksheetPart.Worksheet = worksheet;

                var sheets = document.WorkbookPart.Workbook.AppendChild(new Sheets());
                var sheet = new Sheet()
                {
                    Id = document.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Izveštaj Opreme"
                };
                sheets.Append(sheet);

                workbookPart.Workbook.Save();
            }

            return outputPath;
        }

        private static Columns CreateColumns(Dictionary<int, int> maxLengths)
        {
            var columns = new Columns();

            foreach (var kvp in maxLengths)
            {
                uint colIndex = (uint)kvp.Key;
                double width = kvp.Value + 5;

                var column = new Column
                {
                    Min = colIndex,
                    Max = colIndex,
                    Width = width,
                    CustomWidth = true
                };
                columns.Append(column);
            }

            return columns;
        }

        private static void AddRow(SheetData sheetData, ref uint rowIndex, params string[] cellValues)
        {
            var row = new Row { RowIndex = rowIndex };

            for (int i = 0; i < cellValues.Length; i++)
            {
                string cellReference = GetColumnName(i + 1) + rowIndex;
                var cell = new Cell
                {
                    CellReference = cellReference,
                    DataType = CellValues.String,
                    CellValue = new CellValue(cellValues[i] ?? "")
                };
                row.AppendChild(cell);
            }

            sheetData.AppendChild(row);
            rowIndex++;
        }

        private static string GetColumnName(int columnIndex)
        {
            int dividend = columnIndex;
            string columnName = string.Empty;

            while (dividend > 0)
            {
                int modifier = (dividend - 1) % 26;
                columnName = (char)(65 + modifier) + columnName;
                dividend = (dividend - modifier) / 26;
            }

            return columnName;
        }

        private static string SanitizeFileName(string name)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            foreach (char c in invalidChars)
            {
                name = name.Replace(c, '_');
            }
            return name.Replace(" ", "_");
        }
    }
}
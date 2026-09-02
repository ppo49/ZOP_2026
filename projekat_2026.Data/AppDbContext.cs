using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using projekat_2026.Data.Models;

namespace projekat_2026.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adresar> Adresars { get; set; }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<FirmaObjekat> FirmaObjekats { get; set; }

    public virtual DbSet<ObjekatSistemVeznaTabela> ObjekatSistemVeznaTabelas { get; set; }

    public virtual DbSet<Oprema> Opremas { get; set; }

    public virtual DbSet<PregledLog> PregledLogs { get; set; }

    public virtual DbSet<Sistem> Sistems { get; set; }

    public virtual DbSet<StavkaPregledum> StavkaPregleda { get; set; }

    public virtual DbSet<Telefon> Telefons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=sql7.freesqldatabase.com;port=3306;database=sql7765229;user=sql7765229;password=EDsaiSdGrz", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.5.62-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_unicode_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Adresar>(entity =>
        {
            entity.HasKey(e => e.IdAdresar).HasName("PRIMARY");

            entity.ToTable("adresar");

            entity.Property(e => e.IdAdresar)
                .HasColumnType("int(11)")
                .HasColumnName("id_adresar");
            entity.Property(e => e.Aktivan).HasColumnName("aktivan");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.ImePrezime)
                .HasMaxLength(200)
                .HasColumnName("ime_prezime");
            entity.Property(e => e.Napomena)
                .HasColumnType("text")
                .HasColumnName("napomena");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.IdAgent).HasName("PRIMARY");

            entity.ToTable("agent");

            entity.HasIndex(e => e.SluzbeniEmail, "sluzbeni_email").IsUnique();

            entity.Property(e => e.IdAgent)
                .HasColumnType("int(11)")
                .HasColumnName("id_agent");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.ImePrezime)
                .HasMaxLength(100)
                .HasColumnName("ime_prezime");
            entity.Property(e => e.Pwd)
                .HasMaxLength(255)
                .HasColumnName("_pwd");
            entity.Property(e => e.Role)
                .HasColumnType("enum('agent','admin')")
                .HasColumnName("_role");
            entity.Property(e => e.SluzbeniEmail)
                .HasMaxLength(100)
                .HasColumnName("sluzbeni_email");
            entity.Property(e => e.SluzbeniTelefon)
                .HasMaxLength(50)
                .HasColumnName("sluzbeni_telefon");
            entity.Property(e => e.StatusAktivnosti)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status_aktivnosti");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.IdEmail).HasName("PRIMARY");

            entity.ToTable("email");

            entity.HasIndex(e => e.IdAdresar, "id_adresar");

            entity.Property(e => e.IdEmail)
                .HasColumnType("int(11)")
                .HasColumnName("id_email");
            entity.Property(e => e.Email1)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.IdAdresar)
                .HasColumnType("int(11)")
                .HasColumnName("id_adresar");

            entity.HasOne(d => d.IdAdresarNavigation).WithMany(p => p.Emails)
                .HasForeignKey(d => d.IdAdresar)
                .HasConstraintName("email_ibfk_1");
        });

        modelBuilder.Entity<FirmaObjekat>(entity =>
        {
            entity.HasKey(e => e.IdFirmaObjekat).HasName("PRIMARY");

            entity.ToTable("firma_objekat");

            entity.Property(e => e.IdFirmaObjekat)
                .HasColumnType("int(11)")
                .HasColumnName("id_firma_objekat");
            entity.Property(e => e.Adresa)
                .HasMaxLength(200)
                .HasColumnName("adresa");
            entity.Property(e => e.Aktivan)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("aktivan");
            entity.Property(e => e.BrojZaposlenih)
                .HasColumnType("int(11)")
                .HasColumnName("broj_zaposlenih");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DatumAktivnosti).HasColumnName("datum_aktivnosti");
            entity.Property(e => e.Grad)
                .HasMaxLength(100)
                .HasColumnName("grad");
            entity.Property(e => e.ImeFirmeObjekat)
                .HasMaxLength(200)
                .HasColumnName("ime_firme_objekat");
            entity.Property(e => e.Mb)
                .HasMaxLength(20)
                .HasColumnName("mb");
            entity.Property(e => e.Pib)
                .HasMaxLength(20)
                .HasColumnName("pib");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasMany(d => d.IdAdresars).WithMany(p => p.IdFirmaObjekats)
                .UsingEntity<Dictionary<string, object>>(
                    "FirmaObjekatAdresarVeznaTabela",
                    r => r.HasOne<Adresar>().WithMany()
                        .HasForeignKey("IdAdresar")
                        .HasConstraintName("firma_objekat_adresar_vezna_tabela_ibfk_2"),
                    l => l.HasOne<FirmaObjekat>().WithMany()
                        .HasForeignKey("IdFirmaObjekat")
                        .HasConstraintName("firma_objekat_adresar_vezna_tabela_ibfk_1"),
                    j =>
                    {
                        j.HasKey("IdFirmaObjekat", "IdAdresar")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("firma_objekat_adresar_vezna_tabela");
                        j.HasIndex(new[] { "IdAdresar" }, "id_adresar");
                        j.IndexerProperty<int>("IdFirmaObjekat")
                            .HasColumnType("int(11)")
                            .HasColumnName("id_firma_objekat");
                        j.IndexerProperty<int>("IdAdresar")
                            .HasColumnType("int(11)")
                            .HasColumnName("id_adresar");
                    });
        });

        modelBuilder.Entity<ObjekatSistemVeznaTabela>(entity =>
        {
            entity.HasKey(e => e.IdObjekatSistemVeznaTabela).HasName("PRIMARY");

            entity.ToTable("objekat_sistem_vezna_tabela");

            entity.HasIndex(e => e.IdFirmaObjekat, "id_firma_objekat");

            entity.HasIndex(e => e.IdSistem, "id_sistem");

            entity.Property(e => e.IdObjekatSistemVeznaTabela)
                .HasColumnType("int(11)")
                .HasColumnName("id_objekat_sistem_vezna_tabela");
            entity.Property(e => e.IdFirmaObjekat)
                .HasColumnType("int(11)")
                .HasColumnName("id_firma_objekat");
            entity.Property(e => e.IdSistem)
                .HasColumnType("int(11)")
                .HasColumnName("id_sistem");
            entity.Property(e => e.Napomena)
                .HasMaxLength(100)
                .HasColumnName("napomena");

            entity.HasOne(d => d.IdFirmaObjekatNavigation).WithMany(p => p.ObjekatSistemVeznaTabelas)
                .HasForeignKey(d => d.IdFirmaObjekat)
                .HasConstraintName("objekat_sistem_vezna_tabela_ibfk_1");

            entity.HasOne(d => d.IdSistemNavigation).WithMany(p => p.ObjekatSistemVeznaTabelas)
                .HasForeignKey(d => d.IdSistem)
                .HasConstraintName("objekat_sistem_vezna_tabela_ibfk_2");
        });

        modelBuilder.Entity<Oprema>(entity =>
        {
            entity.HasKey(e => e.IdBarcode).HasName("PRIMARY");

            entity.ToTable("oprema");

            entity.Property(e => e.IdBarcode)
                .HasColumnType("int(11)")
                .HasColumnName("id_barcode");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Napomena)
                .HasMaxLength(100)
                .HasColumnName("napomena");
            entity.Property(e => e.Naziv)
                .HasMaxLength(50)
                .HasColumnName("naziv");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<PregledLog>(entity =>
        {
            entity.HasKey(e => e.IdPregledLog).HasName("PRIMARY");

            entity.ToTable("pregled_log");

            entity.HasIndex(e => e.IdAgent, "id_agent");

            entity.HasIndex(e => e.IdFirmaObjekat, "id_firma_objekat");

            entity.Property(e => e.IdPregledLog)
                .HasColumnType("int(11)")
                .HasColumnName("id_pregled_log");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DatumPregleda).HasColumnName("datum_pregleda");
            entity.Property(e => e.IdAgent)
                .HasColumnType("int(11)")
                .HasColumnName("id_agent");
            entity.Property(e => e.IdFirmaObjekat)
                .HasColumnType("int(11)")
                .HasColumnName("id_firma_objekat");
            entity.Property(e => e.Napomena)
                .HasColumnType("text")
                .HasColumnName("napomena");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.PregledLogs)
                .HasForeignKey(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pregled_log_ibfk_2");

            entity.HasOne(d => d.IdFirmaObjekatNavigation).WithMany(p => p.PregledLogs)
                .HasForeignKey(d => d.IdFirmaObjekat)
                .HasConstraintName("pregled_log_ibfk_1");
        });

        modelBuilder.Entity<Sistem>(entity =>
        {
            entity.HasKey(e => e.IdSistem).HasName("PRIMARY");

            entity.ToTable("sistem");

            entity.Property(e => e.IdSistem)
                .HasColumnType("int(11)")
                .HasColumnName("id_sistem");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Napomena)
                .HasColumnType("text")
                .HasColumnName("napomena");
            entity.Property(e => e.Naziv)
                .HasMaxLength(200)
                .HasColumnName("naziv");
            entity.Property(e => e.Periodika)
                .HasColumnType("int(11)")
                .HasColumnName("periodika");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<StavkaPregledum>(entity =>
        {
            entity.HasKey(e => e.IdStavkaPregleda).HasName("PRIMARY");

            entity.ToTable("stavka_pregleda");

            entity.HasIndex(e => e.IdObjekatSistemVeznaTabela, "id_objekat_sistem_vezna_tabela");

            entity.HasIndex(e => new { e.IdPregledLog, e.IdObjekatSistemVeznaTabela }, "id_pregled_log").IsUnique();

            entity.Property(e => e.IdStavkaPregleda)
                .HasColumnType("int(11)")
                .HasColumnName("id_stavka_pregleda");
            entity.Property(e => e.IdObjekatSistemVeznaTabela)
                .HasColumnType("int(11)")
                .HasColumnName("id_objekat_sistem_vezna_tabela");
            entity.Property(e => e.IdPregledLog)
                .HasColumnType("int(11)")
                .HasColumnName("id_pregled_log");
            entity.Property(e => e.NapomenaStavke)
                .HasColumnType("text")
                .HasColumnName("napomena_stavke");
            entity.Property(e => e.Zadovoljava).HasColumnName("zadovoljava");

            entity.HasOne(d => d.IdObjekatSistemVeznaTabelaNavigation).WithMany(p => p.StavkaPregleda)
                .HasForeignKey(d => d.IdObjekatSistemVeznaTabela)
                .HasConstraintName("stavka_pregleda_ibfk_2");

            entity.HasOne(d => d.IdPregledLogNavigation).WithMany(p => p.StavkaPregleda)
                .HasForeignKey(d => d.IdPregledLog)
                .HasConstraintName("stavka_pregleda_ibfk_1");
        });

        modelBuilder.Entity<Telefon>(entity =>
        {
            entity.HasKey(e => e.IdTelefon).HasName("PRIMARY");

            entity.ToTable("telefon");

            entity.HasIndex(e => e.IdAdresar, "id_adresar");

            entity.Property(e => e.IdTelefon)
                .HasColumnType("int(11)")
                .HasColumnName("id_telefon");
            entity.Property(e => e.IdAdresar)
                .HasColumnType("int(11)")
                .HasColumnName("id_adresar");
            entity.Property(e => e.Telefon1)
                .HasMaxLength(20)
                .HasColumnName("telefon");

            entity.HasOne(d => d.IdAdresarNavigation).WithMany(p => p.Telefons)
                .HasForeignKey(d => d.IdAdresar)
                .HasConstraintName("telefon_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

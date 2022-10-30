using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FabricaIdeas.Models
{
    public partial class DbFabriIdeasContext : DbContext
    {
        public DbFabriIdeasContext()
        {
        }

        public DbFabriIdeasContext(DbContextOptions<DbFabriIdeasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<Estatus> Estatuses { get; set; } = null!;
        public virtual DbSet<Idea> Ideas { get; set; } = null!;
        public virtual DbSet<Objetivo> Objetivos { get; set; } = null!;
        public virtual DbSet<Premiacion> Premiacions { get; set; } = null!;
        public virtual DbSet<Respon> Respons { get; set; } = null!;
        public virtual DbSet<Zona> Zonas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.IdArea)
                    .HasName("PK__Area__2FC141AAB97B916B");

                entity.ToTable("Area");

                entity.Property(e => e.Adescri)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ADescri");

                entity.Property(e => e.Aesta).HasColumnName("AEsta");

                entity.Property(e => e.Anombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ANombre");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCate)
                    .HasName("PK__Categori__3B7B6402AF9F9E92");

                entity.Property(e => e.Cdescrip)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CDescrip");

                entity.Property(e => e.Cesta).HasColumnName("CEsta");

                entity.Property(e => e.Crango).HasColumnName("CRango");
            });

            modelBuilder.Entity<Estatus>(entity =>
            {
                entity.HasKey(e => e.IdEstatus)
                    .HasName("PK__Estatus__B32BA1C77C0C6526");

                entity.ToTable("Estatus");

                entity.Property(e => e.Edesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EDesc");

                entity.Property(e => e.Eesta).HasColumnName("EEsta");

                entity.Property(e => e.Enivel).HasColumnName("ENivel");
            });

            modelBuilder.Entity<Idea>(entity =>
            {
                entity.HasKey(e => e.IdIdea)
                    .HasName("PK__Idea__6DE8190317C73A32");

                entity.ToTable("Idea");

                entity.Property(e => e.AidArea).HasColumnName("AIdArea");

                entity.Property(e => e.EidEsta).HasColumnName("EIdEsta");

                entity.Property(e => e.Iacti).HasColumnName("IActi");

                entity.Property(e => e.Idesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("IDesc");

                entity.Property(e => e.Iecarga)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("IEcarga");

                entity.Property(e => e.Iesta)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("IEsta");

                entity.Property(e => e.Ifacti)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("IFacti");

                entity.Property(e => e.Inombre)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("INombre");

                entity.Property(e => e.Isolu)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("ISolu");

                entity.Property(e => e.PidPremi).HasColumnName("PIdPremi");

                entity.Property(e => e.ZidZona).HasColumnName("ZIdZona");

                entity.HasOne(d => d.AidAreaNavigation)
                    .WithMany(p => p.Ideas)
                    .HasForeignKey(d => d.AidArea)
                    .HasConstraintName("FK_Idea_Area");

                entity.HasOne(d => d.EidEstaNavigation)
                    .WithMany(p => p.Ideas)
                    .HasForeignKey(d => d.EidEsta)
                    .HasConstraintName("FK_Idea_Estatus");

                entity.HasOne(d => d.PidPremiNavigation)
                    .WithMany(p => p.Ideas)
                    .HasForeignKey(d => d.PidPremi)
                    .HasConstraintName("FK_Idea_Premiacion");

                entity.HasOne(d => d.ZidZonaNavigation)
                    .WithMany(p => p.Ideas)
                    .HasForeignKey(d => d.ZidZona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Idea_Zona");
            });

            modelBuilder.Entity<Objetivo>(entity =>
            {
                entity.HasKey(e => e.IdObje)
                    .HasName("PK__Objetivo__8034FF389B3AC8F4");

                entity.Property(e => e.IidIdea).HasColumnName("IIdIdea");

                entity.Property(e => e.Odesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("ODesc");

                entity.Property(e => e.Oesta).HasColumnName("OEsta");

                entity.Property(e => e.Onivel).HasColumnName("ONivel");

                entity.HasOne(d => d.IidIdeaNavigation)
                    .WithMany(p => p.Objetivos)
                    .HasForeignKey(d => d.IidIdea)
                    .HasConstraintName("FK_Objetivos_Idea");
            });

            modelBuilder.Entity<Premiacion>(entity =>
            {
                entity.HasKey(e => e.IdPremi)
                    .HasName("PK__Premiaci__CCE2F3BE5F37E744");

                entity.ToTable("Premiacion");

                entity.Property(e => e.CidCat).HasColumnName("CIdCat");

                entity.Property(e => e.Pmonto).HasColumnName("PMonto");

                entity.Property(e => e.Pobser)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PObser");

                entity.HasOne(d => d.CidCatNavigation)
                    .WithMany(p => p.Premiacions)
                    .HasForeignKey(d => d.CidCat)
                    .HasConstraintName("FK_Premiacion_Categoria");
            });

            modelBuilder.Entity<Respon>(entity =>
            {
                entity.HasKey(e => e.IdRespon)
                    .HasName("PK__Respons__D91D3EC7EE9C3809");

                entity.Property(e => e.IidIdea).HasColumnName("IIdIdea");

                entity.Property(e => e.Resta).HasColumnName("REsta");

                entity.Property(e => e.Rficha)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RFicha");

                entity.Property(e => e.Rnombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RNombre");

                entity.Property(e => e.Rnum).HasColumnName("RNum");

                entity.HasOne(d => d.IidIdeaNavigation)
                    .WithMany(p => p.Respons)
                    .HasForeignKey(d => d.IidIdea)
                    .HasConstraintName("FK_Respons_Idea");
            });

            modelBuilder.Entity<Zona>(entity =>
            {
                entity.HasKey(e => e.IdZona)
                    .HasName("PK__Zona__F631C12DAD2787C8");

                entity.ToTable("Zona");

                entity.Property(e => e.AidArea).HasColumnName("AIdArea");

                entity.Property(e => e.Zcentro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ZCentro");

                entity.Property(e => e.Znombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZNombre");

                entity.HasOne(d => d.AidAreaNavigation)
                    .WithMany(p => p.Zonas)
                    .HasForeignKey(d => d.AidArea)
                    .HasConstraintName("FK_Zona_Area");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Dziennik
{
    public partial class baza : DbContext
    {
        public baza()
        {
        }

        public baza(DbContextOptions<baza> options)
            : base(options)
        {
        }

        public virtual DbSet<AktualnyPrzedmiot> AktualnyPrzedmiots { get; set; }
        public virtual DbSet<Klasa> Klasas { get; set; }
        public virtual DbSet<Nauczyciel> Nauczyciels { get; set; }
        public virtual DbSet<Ocena> Ocenas { get; set; }
        public virtual DbSet<Opiekun> Opiekuns { get; set; }
        public virtual DbSet<Przedmiot> Przedmiots { get; set; }
        public virtual DbSet<Uczen> Uczens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning: „To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.”
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Filename=baza.db");
#pragma warning restore CS1030 // #warning: „To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.”
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AktualnyPrzedmiot>(entity =>
            {
                entity.Property(e => e.IdAktPrzed).ValueGeneratedNever();

                entity.HasOne(d => d.IdKlasaNavigation)
                    .WithMany(p => p.AktualnyPrzedmiots)
                    .HasForeignKey(d => d.IdKlasa)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdNauczycielNavigation)
                    .WithMany(p => p.AktualnyPrzedmiots)
                    .HasForeignKey(d => d.IdNauczyciel)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPrzedmiotNavigation)
                    .WithMany(p => p.AktualnyPrzedmiots)
                    .HasForeignKey(d => d.IdPrzedmiot)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Klasa>(entity =>
            {
                entity.Property(e => e.IdKlasa).ValueGeneratedNever();
            });

            modelBuilder.Entity<Nauczyciel>(entity =>
            {
                entity.Property(e => e.IdNauczyciel).ValueGeneratedNever();
            });

            modelBuilder.Entity<Ocena>(entity =>
            {
               // entity.Property(e => e.IdOcena).ValueGeneratedNever();

                entity.HasOne(d => d.IdNauczycielNavigation)
                    .WithMany(p => p.Ocenas)
                    .HasForeignKey(d => d.IdNauczyciel)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPrzedmiotNavigation)
                    .WithMany(p => p.Ocenas)
                    .HasForeignKey(d => d.IdPrzedmiot)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdUczenNavigation)
                    .WithMany(p => p.Ocenas)
                    .HasForeignKey(d => d.IdUczen)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Opiekun>(entity =>
            {
                entity.Property(e => e.IdOpiekun).ValueGeneratedNever();
            });

            modelBuilder.Entity<Przedmiot>(entity =>
            {
                entity.Property(e => e.IdPrzedmiot).ValueGeneratedNever();
            });

            modelBuilder.Entity<Uczen>(entity =>
            {
                entity.Property(e => e.IdUczen).ValueGeneratedNever();

                entity.HasOne(d => d.IdOpiekunNavigation)
                    .WithMany(p => p.Uczens)
                    .HasForeignKey(d => d.IdOpiekun)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

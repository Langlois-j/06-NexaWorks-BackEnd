using Microsoft.EntityFrameworkCore;
using _06_NexaWorks_BackEnd.Models;

namespace _06_NexaWorks_BackEnd.Data
{
    public class NexaWorksContext : DbContext
    {
        public NexaWorksContext(DbContextOptions<NexaWorksContext> options)
            : base(options)
        {
        }

        public DbSet<Produit> Produit { get; set; }
        public DbSet<VersionProduit> VersionProduit { get; set; }
        public DbSet<OS> OS { get; set; }
        public DbSet<VersionProduitOS> VersionProduitOS { get; set; }
        public DbSet<Statut> Statuts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Produit)
                .WithMany()
                .HasForeignKey(t => t.IdProduit)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.VersionProduit)
                .WithMany()
                .HasForeignKey(t => t.IdVersionProduit)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.OS)
                .WithMany()
                .HasForeignKey(t => t.IdOs)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Statut)
                .WithMany()
                .HasForeignKey(t => t.IdStatut)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<VersionProduit>()
    .HasOne(v => v.Produit)
    .WithMany()
    .HasForeignKey(v => v.IdProduit)
    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
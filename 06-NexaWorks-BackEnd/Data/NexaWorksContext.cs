using _06_NexaWorks_BackEnd.Models;
using Microsoft.EntityFrameworkCore;


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
    }
}
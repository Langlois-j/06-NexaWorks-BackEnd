using _06_NexaWorks_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace _06_NexaWorks_BackEnd.Data.Seeds
{
    public class ProduitSeeder
    {
        private readonly NexaWorksContext _context;

        public ProduitSeeder(NexaWorksContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Produits.Any())
            {
                _context.Produits.AddRange(
                    new Produit { NomProduit = "Trader en Herbe" },
                    new Produit { NomProduit = "Maître des Investissements" },
                    new Produit { NomProduit = "Planificateur d'Entraînement" },
                    new Produit { NomProduit = "Planificateur d'Anxiété Sociale" }
                );
                _context.SaveChanges();
            }
        }
    }
}

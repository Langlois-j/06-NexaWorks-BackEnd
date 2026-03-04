using _06_NexaWorks_BackEnd.Models;

namespace _06_NexaWorks_BackEnd.Data.Seeds
{
    public class VersionProduitSeeder
    {
        private readonly NexaWorksContext _context;

        public VersionProduitSeeder(NexaWorksContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.VersionProduits.Any())
            {
                var traderHerbe = _context.Produits.First(p => p.NomProduit == "Trader en Herbe");
                var maitreInvest = _context.Produits.First(p => p.NomProduit == "Maître des Investissements");
                var planifEntrain = _context.Produits.First(p => p.NomProduit == "Planificateur d'Entraînement");
                var planifAnxiete = _context.Produits.First(p => p.NomProduit == "Planificateur d'Anxiété Sociale");

                _context.VersionProduits.AddRange(
                    new VersionProduit { NomVersion = "1.0", IdProduit = traderHerbe.Id },
                    new VersionProduit { NomVersion = "1.1", IdProduit = traderHerbe.Id },
                    new VersionProduit { NomVersion = "1.2", IdProduit = traderHerbe.Id },
                    new VersionProduit { NomVersion = "1.3", IdProduit = traderHerbe.Id },
                    new VersionProduit { NomVersion = "1.0", IdProduit = maitreInvest.Id },
                    new VersionProduit { NomVersion = "2.0", IdProduit = maitreInvest.Id },
                    new VersionProduit { NomVersion = "2.1", IdProduit = maitreInvest.Id },
                    new VersionProduit { NomVersion = "1.0", IdProduit = planifEntrain.Id },
                    new VersionProduit { NomVersion = "1.1", IdProduit = planifEntrain.Id },
                    new VersionProduit { NomVersion = "2.0", IdProduit = planifEntrain.Id },
                    new VersionProduit { NomVersion = "1.0", IdProduit = planifAnxiete.Id },
                    new VersionProduit { NomVersion = "1.1", IdProduit = planifAnxiete.Id }
                );
                _context.SaveChanges();
            }
        }
    }
}

using _06_NexaWorks_BackEnd.Models;

namespace _06_NexaWorks_BackEnd.Data
{
    public class DataSeeder
    {
        private readonly NexaWorksContext _context;

        public DataSeeder(NexaWorksContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.OS.Any())
            {
                _context.OS.AddRange(
                    new OS { NomOS = "Windows" },
                    new OS { NomOS = "Linux" },
                    new OS { NomOS = "MacOS" },
                    new OS { NomOS = "Android" },
                    new OS { NomOS = "iOS" },
                    new OS { NomOS = "Windows Mobile" }
                );
                _context.SaveChanges();
            }

            if (!_context.Statuts.Any())
            {
                _context.Statuts.AddRange(
                    new Statut { NomStatut = "En cours" },
                    new Statut { NomStatut = "Résolu" }
                );
                _context.SaveChanges();
            }

            if (!_context.Produit.Any())
            {
                _context.Produit.AddRange(
                    new Produit { NomProduit = "Trader en Herbe" },
                    new Produit { NomProduit = "Maître des Investissements" },
                    new Produit { NomProduit = "Planificateur d'Entraînement" },
                    new Produit { NomProduit = "Planificateur d'Anxiété Sociale" }
                );
                _context.SaveChanges();
            }

            if (!_context.VersionProduit.Any())
            {
                var traderHerbe = _context.Produit.First(p => p.NomProduit == "Trader en Herbe");
                var maitreInvest = _context.Produit.First(p => p.NomProduit == "Maître des Investissements");
                var planifEntrain = _context.Produit.First(p => p.NomProduit == "Planificateur d'Entraînement");
                var planifAnxiete = _context.Produit.First(p => p.NomProduit == "Planificateur d'Anxiété Sociale");

                _context.VersionProduit.AddRange(
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
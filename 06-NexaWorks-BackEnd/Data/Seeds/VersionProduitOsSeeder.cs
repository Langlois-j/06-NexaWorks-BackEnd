using _06_NexaWorks_BackEnd.Models;

namespace _06_NexaWorks_BackEnd.Data.Seeds
{
    public class VersionProduitOsSeeder
    {
        private readonly NexaWorksContext _context;

        public VersionProduitOsSeeder(NexaWorksContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.VersionProduitOS.Any())
            {
                // Récupération des versions par produit
                // On utilise le nom du produit pour identifier la bonne version
                var th10 = _context.VersionProduits.First(v => v.NomVersion == "1.0" && v.Produit.NomProduit == "Trader en Herbe");
                var th11 = _context.VersionProduits.First(v => v.NomVersion == "1.1" && v.Produit.NomProduit == "Trader en Herbe");
                var th12 = _context.VersionProduits.First(v => v.NomVersion == "1.2" && v.Produit.NomProduit == "Trader en Herbe");
                var th13 = _context.VersionProduits.First(v => v.NomVersion == "1.3" && v.Produit.NomProduit == "Trader en Herbe");

                var mi10 = _context.VersionProduits.First(v => v.NomVersion == "1.0" && v.Produit.NomProduit == "Maître des Investissements");
                var mi20 = _context.VersionProduits.First(v => v.NomVersion == "2.0" && v.Produit.NomProduit == "Maître des Investissements");
                var mi21 = _context.VersionProduits.First(v => v.NomVersion == "2.1" && v.Produit.NomProduit == "Maître des Investissements");

                var pe10 = _context.VersionProduits.First(v => v.NomVersion == "1.0" && v.Produit.NomProduit == "Planificateur d'Entraînement");
                var pe11 = _context.VersionProduits.First(v => v.NomVersion == "1.1" && v.Produit.NomProduit == "Planificateur d'Entraînement");
                var pe20 = _context.VersionProduits.First(v => v.NomVersion == "2.0" && v.Produit.NomProduit == "Planificateur d'Entraînement");

                var pa10 = _context.VersionProduits.First(v => v.NomVersion == "1.0" && v.Produit.NomProduit == "Planificateur d'Anxiété Sociale");
                var pa11 = _context.VersionProduits.First(v => v.NomVersion == "1.1" && v.Produit.NomProduit == "Planificateur d'Anxiété Sociale");

                // Récupération des OS
                var windows = _context.OS.First(o => o.NomOS == "Windows");
                var linux = _context.OS.First(o => o.NomOS == "Linux");
                var macos = _context.OS.First(o => o.NomOS == "MacOS");
                var android = _context.OS.First(o => o.NomOS == "Android");
                var ios = _context.OS.First(o => o.NomOS == "iOS");
                var windowsMobile = _context.OS.First(o => o.NomOS == "Windows Mobile");

                _context.VersionProduitOS.AddRange(
                    // Trader en Herbe 1.0 → Linux, MacOS
                    new VersionProduitOS { IdVersionProduit = th10.Id, IdOs = linux.Id },
                    new VersionProduitOS { IdVersionProduit = th10.Id, IdOs = macos.Id },
                    // Trader en Herbe 1.1 → Linux, Windows, iOS
                    new VersionProduitOS { IdVersionProduit = th11.Id, IdOs = linux.Id },
                    new VersionProduitOS { IdVersionProduit = th11.Id, IdOs = windows.Id },
                    new VersionProduitOS { IdVersionProduit = th11.Id, IdOs = ios.Id },
                    // Trader en Herbe 1.2 → tous les OS
                    new VersionProduitOS { IdVersionProduit = th12.Id, IdOs = linux.Id },
                    new VersionProduitOS { IdVersionProduit = th12.Id, IdOs = macos.Id },
                    new VersionProduitOS { IdVersionProduit = th12.Id, IdOs = windows.Id },
                    new VersionProduitOS { IdVersionProduit = th12.Id, IdOs = android.Id },
                    new VersionProduitOS { IdVersionProduit = th12.Id, IdOs = ios.Id },
                    new VersionProduitOS { IdVersionProduit = th12.Id, IdOs = windowsMobile.Id },
                    // Trader en Herbe 1.3 → Linux, MacOS, Windows, Android
                    new VersionProduitOS { IdVersionProduit = th13.Id, IdOs = linux.Id },
                    new VersionProduitOS { IdVersionProduit = th13.Id, IdOs = macos.Id },
                    new VersionProduitOS { IdVersionProduit = th13.Id, IdOs = windows.Id },
                    new VersionProduitOS { IdVersionProduit = th13.Id, IdOs = android.Id },
                    // Maître des Investissements 1.0 → Linux, MacOS
                    new VersionProduitOS { IdVersionProduit = mi10.Id, IdOs = linux.Id },
                    new VersionProduitOS { IdVersionProduit = mi10.Id, IdOs = macos.Id },
                    // Maître des Investissements 2.0 → MacOS, Windows, Android
                    new VersionProduitOS { IdVersionProduit = mi20.Id, IdOs = macos.Id },
                    new VersionProduitOS { IdVersionProduit = mi20.Id, IdOs = windows.Id },
                    new VersionProduitOS { IdVersionProduit = mi20.Id, IdOs = android.Id },
                    // Maître des Investissements 2.1 → MacOS, Windows, Android, iOS
                    new VersionProduitOS { IdVersionProduit = mi21.Id, IdOs = macos.Id },
                    new VersionProduitOS { IdVersionProduit = mi21.Id, IdOs = windows.Id },
                    new VersionProduitOS { IdVersionProduit = mi21.Id, IdOs = android.Id },
                    new VersionProduitOS { IdVersionProduit = mi21.Id, IdOs = ios.Id },
                    // Planificateur d'Entraînement 1.0 → Linux, MacOS
                    new VersionProduitOS { IdVersionProduit = pe10.Id, IdOs = linux.Id },
                    new VersionProduitOS { IdVersionProduit = pe10.Id, IdOs = macos.Id },
                    // Planificateur d'Entraînement 1.1 → tous les OS
                    new VersionProduitOS { IdVersionProduit = pe11.Id, IdOs = linux.Id },
                    new VersionProduitOS { IdVersionProduit = pe11.Id, IdOs = macos.Id },
                    new VersionProduitOS { IdVersionProduit = pe11.Id, IdOs = windows.Id },
                    new VersionProduitOS { IdVersionProduit = pe11.Id, IdOs = android.Id },
                    new VersionProduitOS { IdVersionProduit = pe11.Id, IdOs = ios.Id },
                    new VersionProduitOS { IdVersionProduit = pe11.Id, IdOs = windowsMobile.Id },
                    // Planificateur d'Entraînement 2.0 → MacOS, Windows, Android, iOS
                    new VersionProduitOS { IdVersionProduit = pe20.Id, IdOs = macos.Id },
                    new VersionProduitOS { IdVersionProduit = pe20.Id, IdOs = windows.Id },
                    new VersionProduitOS { IdVersionProduit = pe20.Id, IdOs = android.Id },
                    new VersionProduitOS { IdVersionProduit = pe20.Id, IdOs = ios.Id },
                    // Planificateur d'Anxiété Sociale 1.0 → MacOS, Windows, Android, iOS
                    new VersionProduitOS { IdVersionProduit = pa10.Id, IdOs = macos.Id },
                    new VersionProduitOS { IdVersionProduit = pa10.Id, IdOs = windows.Id },
                    new VersionProduitOS { IdVersionProduit = pa10.Id, IdOs = android.Id },
                    new VersionProduitOS { IdVersionProduit = pa10.Id, IdOs = ios.Id },
                    // Planificateur d'Anxiété Sociale 1.1 → MacOS, Windows, Android, iOS
                    new VersionProduitOS { IdVersionProduit = pa11.Id, IdOs = macos.Id },
                    new VersionProduitOS { IdVersionProduit = pa11.Id, IdOs = windows.Id },
                    new VersionProduitOS { IdVersionProduit = pa11.Id, IdOs = android.Id },
                    new VersionProduitOS { IdVersionProduit = pa11.Id, IdOs = ios.Id }
                );
                _context.SaveChanges();
            }
        }
    }
}
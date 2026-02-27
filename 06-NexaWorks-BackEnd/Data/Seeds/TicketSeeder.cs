using _06_NexaWorks_BackEnd.Models;
using System.Diagnostics;
using System.Numerics;

namespace _06_NexaWorks_BackEnd.Data.Seeds
{
    public class TicketSeeder
    {
        private readonly NexaWorksContext _context;

        public TicketSeeder(NexaWorksContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Tickets.Any())
            {
                // Récupération des entités
                var windows = _context.OS.First(o => o.NomOS == "Windows");
                var linux = _context.OS.First(o => o.NomOS == "Linux");
                var macos = _context.OS.First(o => o.NomOS == "MacOS");
                var android = _context.OS.First(o => o.NomOS == "Android");
                var ios = _context.OS.First(o => o.NomOS == "iOS");
                var windowsMobile = _context.OS.First(o => o.NomOS == "Windows Mobile");

                var enCours = _context.Statuts.First(s => s.NomStatut == "En cours");
                var resolu = _context.Statuts.First(s => s.NomStatut == "Résolu");

                var traderHerbe = _context.Produit.First(p => p.NomProduit == "Trader en Herbe");
                var maitreInvest = _context.Produit.First(p => p.NomProduit == "Maître des Investissements");
                var planifEntrain = _context.Produit.First(p => p.NomProduit == "Planificateur d'Entraînement");
                var planifAnxiete = _context.Produit.First(p => p.NomProduit == "Planificateur d'Anxiété Sociale");

                var th10 = _context.VersionProduit.First(v => v.NomVersion == "1.0" && v.IdProduit == traderHerbe.Id);
                var th11 = _context.VersionProduit.First(v => v.NomVersion == "1.1" && v.IdProduit == traderHerbe.Id);
                var th12 = _context.VersionProduit.First(v => v.NomVersion == "1.2" && v.IdProduit == traderHerbe.Id);
                var th13 = _context.VersionProduit.First(v => v.NomVersion == "1.3" && v.IdProduit == traderHerbe.Id);
                var mi10 = _context.VersionProduit.First(v => v.NomVersion == "1.0" && v.IdProduit == maitreInvest.Id);
                var mi20 = _context.VersionProduit.First(v => v.NomVersion == "2.0" && v.IdProduit == maitreInvest.Id);
                var mi21 = _context.VersionProduit.First(v => v.NomVersion == "2.1" && v.IdProduit == maitreInvest.Id);
                var pe10 = _context.VersionProduit.First(v => v.NomVersion == "1.0" && v.IdProduit == planifEntrain.Id);
                var pe11 = _context.VersionProduit.First(v => v.NomVersion == "1.1" && v.IdProduit == planifEntrain.Id);
                var pe20 = _context.VersionProduit.First(v => v.NomVersion == "2.0" && v.IdProduit == planifEntrain.Id);
                var pa10 = _context.VersionProduit.First(v => v.NomVersion == "1.0" && v.IdProduit == planifAnxiete.Id);
                var pa11 = _context.VersionProduit.First(v => v.NomVersion == "1.1" && v.IdProduit == planifAnxiete.Id);

                _context.Tickets.AddRange(

                    // =============================================
                    // TRADER EN HERBE
                    // =============================================

                    // --- Version 1.0 ---
                    // Windows - Résolu
                    new Ticket
                    {
                        IdProduit = traderHerbe.Id,
                        IdVersionProduit = th10.Id,
                        IdOs = windows.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 1, 3),
                        ResolutionDate = new DateOnly(2023, 1, 17),
                        DescriptionTexte = "Depuis une mise à jour de Windows, l'application ne se lance plus. Un message s'affiche indiquant qu'une mise à jour du runtime .NET est nécessaire pour continuer.",
                        ResolutionTexte = "L'utilisateur a été guidé pour télécharger et installer la version requise du runtime .NET depuis le site officiel de Microsoft. Après redémarrage, l'application fonctionne normalement. Une note a été envoyée à l'équipe de développement pour intégrer une vérification automatique du runtime au démarrage."
                    },

                    // --- Version 1.1 ---
                    // Linux - Résolu
                    new Ticket
                    {
                        IdProduit = traderHerbe.Id,
                        IdVersionProduit = th11.Id,
                        IdOs = linux.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 1, 18),
                        ResolutionDate = new DateOnly(2023, 2, 1),
                        DescriptionTexte = "L'application s'ouvre correctement mais l'utilisateur ne peut pas se connecter à son compte. Le champ mot de passe semble accepter la saisie mais rien ne se passe lorsqu'il clique sur le bouton de connexion.",
                        ResolutionTexte = "Un problème de compatibilité avec certaines distributions Linux empêchait l'envoi du formulaire de connexion. Le bouton était bien cliqué mais l'événement n'était pas transmis correctement. Un correctif a été déployé ciblant la gestion des événements sur Linux."
                    },
                    // MacOS - En cours
                    new Ticket
                    {
                        IdProduit = traderHerbe.Id,
                        IdVersionProduit = th11.Id,
                        IdOs = macos.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 1, 10),
                        ResolutionDate = null,
                        DescriptionTexte = "L'utilisateur signale que les cours boursiers affichés dans l'application ne se mettent plus à jour depuis deux jours. Les prix restent figés sur les valeurs de l'ouverture du marché, quelle que soit l'heure de consultation.",
                        ResolutionTexte = null
                    },
                    // Windows - En cours
                    new Ticket
                    {
                        IdProduit = traderHerbe.Id,
                        IdVersionProduit = th11.Id,
                        IdOs = windows.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 11, 23),
                        ResolutionDate = null,
                        DescriptionTexte = "L'utilisateur signale un affichage incorrect des nombres décimaux dans son portefeuille. Les valeurs s'affichent avec un point comme séparateur décimal alors que son système est configuré en français (virgule). Cela rend les valeurs difficiles à lire.",
                        ResolutionTexte = null
                    },

                    // --- Version 1.2 ---
         
                    // Linux - En cours
                    new Ticket
                    {
                        IdProduit = traderHerbe.Id,
                        IdVersionProduit = th12.Id,
                        IdOs = linux.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 3, 1),
                        ResolutionDate = null,
                        DescriptionTexte = "L'utilisateur rapporte que la fonctionnalité d'exportation de l'historique de transactions au format CSV ne fonctionne pas sous Linux. Lorsqu'il clique sur \"Exporter\", rien ne se passe. L'export fonctionne correctement sur Windows et MacOS.",
                        ResolutionTexte = null
                    },
                    // Windows Mobile - Résolu
                    new Ticket
                    {
                        IdProduit = traderHerbe.Id,
                        IdVersionProduit = th12.Id,
                        IdOs = windowsMobile.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 3, 7),
                        ResolutionDate = new DateOnly(2023, 3, 22),
                        DescriptionTexte = "Sur Windows Mobile, les chiffres du portefeuille s'affichent trop grands et débordent hors de l'écran. L'interface n'est pas adaptée à la taille de l'écran du téléphone et certaines informations sont inaccessibles.",
                        ResolutionTexte = "Les tailles de police n'étaient pas adaptées au format mobile sous Windows Mobile. Des feuilles de style responsives ont été ajoutées spécifiquement pour Windows Mobile, corrigeant l'affichage sur tous les modèles testés."
                    },

                    // --- Version 1.3 ---
                    // Android - Résolu
                    new Ticket
                    {
                        IdProduit = traderHerbe.Id,
                        IdVersionProduit = th13.Id,
                        IdOs = android.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 2, 5),
                        ResolutionDate = new DateOnly(2023, 2, 20),
                        DescriptionTexte = "L'utilisateur signale que l'application se ferme toute seule lors de la consultation de l'historique de ses transactions. Le problème se produit systématiquement après quelques secondes de navigation dans cette section.",
                        ResolutionTexte = "Un crash se produisait lors du chargement d'un historique contenant plus de 200 transactions en raison d'un dépassement de mémoire. La pagination a été mise en place pour charger les transactions par lot de 50, ce qui a résolu le problème."
                    },

                    // =============================================
                    // MAITRE DES INVESTISSEMENTS
                    // =============================================

                    // --- Version 1.0 ---
                    // MacOS - Résolu
                    new Ticket
                    {
                        IdProduit = maitreInvest.Id,
                        IdVersionProduit = mi10.Id,
                        IdOs = macos.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 5, 22),
                        ResolutionDate = new DateOnly(2023, 6, 6),
                        DescriptionTexte = "Lors de l'ajout d'un actif au portefeuille, le champ de recherche d'actions ne renvoie aucun résultat sur MacOS. La barre de recherche semble fonctionner (le curseur clignote) mais les suggestions n'apparaissent jamais.",
                        ResolutionTexte = "Une requête réseau était bloquée par le pare-feu applicatif de MacOS à cause d'un certificat SSL non reconnu par le système sur cette version. Le certificat a été mis à jour et les autorisations réseau revues."
                    },
                    // iOS - En cours
                    new Ticket
                    {
                        IdProduit = maitreInvest.Id,
                        IdVersionProduit = mi10.Id,
                        IdOs = ios.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 12, 21),
                        ResolutionDate = null,
                        DescriptionTexte = "L'utilisateur iOS signale que les widgets de l'application affichés sur son écran d'accueil iPhone ne se rafraîchissent pas. Les informations du widget restent figées sur les données du matin même quand les marchés ont évolué.",
                        ResolutionTexte = null
                    },

                    // --- Version 2.0 ---
                    // MacOS - En cours
                    new Ticket
                    {
                        IdProduit = maitreInvest.Id,
                        IdVersionProduit = mi20.Id,
                        IdOs = macos.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 4, 28),
                        ResolutionDate = null,
                        DescriptionTexte = "L'application se met en veille automatiquement après 2 minutes d'inactivité sur MacOS, alors que l'utilisateur consulte des informations à l'écran sans interagir. Cette mise en veille interrompt les actualisations en cours.",
                        ResolutionTexte = null
                    },

                    // --- Version 2.1 ---
                    // Android - En cours
                    new Ticket
                    {
                        IdProduit = maitreInvest.Id,
                        IdVersionProduit = mi21.Id,
                        IdOs = android.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 5, 30),
                        ResolutionDate = null,
                        DescriptionTexte = "L'utilisateur Android signale que la page d'accueil du tableau de bord met très longtemps à se charger, parfois plus d'une minute. Le problème empire avec le temps et semble lié au nombre d'actifs dans le portefeuille.",
                        ResolutionTexte = null
                    },
                    // iOS - Résolu
                    new Ticket
                    {
                        IdProduit = maitreInvest.Id,
                        IdVersionProduit = mi21.Id,
                        IdOs = ios.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 6, 7),
                        ResolutionDate = new DateOnly(2023, 6, 21),
                        DescriptionTexte = "L'utilisateur iOS ne peut pas activer l'authentification à deux facteurs (2FA) depuis les paramètres de l'application. Le bouton d'activation est présent mais ne répond pas aux tapotements.",
                        ResolutionTexte = "La vue des paramètres sur iOS avait une superposition invisible bloquant les interactions tactiles sur cette zone spécifique. Après correction du layout, le bouton 2FA répond correctement."
                    },
                    // Windows - Résolu
                    new Ticket
                    {
                        IdProduit = maitreInvest.Id,
                        IdVersionProduit = mi21.Id,
                        IdOs = windows.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 4, 20),
                        ResolutionDate = new DateOnly(2023, 5, 4),
                        DescriptionTexte = "L'utilisateur ne parvient pas à créer un nouveau portefeuille. Lorsqu'il remplit le formulaire et clique sur créer, un message d'erreur générique s'affiche : \"Une erreur est survenue\", sans plus d'information.",
                        ResolutionTexte = "Le serveur retournait une erreur 500 non affichée correctement côté client. En consultant les logs, une contrainte de base de données empêchait la création de deux portefeuilles avec le même nom pour un même utilisateur. Un message d'erreur explicite a été ajouté pour informer l'utilisateur que le nom du portefeuille existe déjà."
                    },

                    // =============================================
                    // PLANIFICATEUR D'ENTRAINEMENT
                    // =============================================

                    // --- Version 1.0 ---
                    // MacOS - Résolu
                    new Ticket
                    {
                        IdProduit = planifEntrain.Id,
                        IdVersionProduit = pe10.Id,
                        IdOs = macos.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 6, 14),
                        ResolutionDate = new DateOnly(2023, 6, 28),
                        DescriptionTexte = "L'utilisateur signale que la synchronisation avec son compte Apple Health ne fonctionne pas. Après avoir accordé les autorisations, les données de ses séances de sport ne sont pas importées.",
                        ResolutionTexte = "Une autorisation supplémentaire liée à HealthKit n'avait pas été demandée lors de l'installation. Une mise à jour de l'application a ajouté cette demande d'autorisation dès le premier lancement, résolvant ainsi le problème de synchronisation."
                    },

                    // --- Version 1.1 ---
                    // Android - En cours
                    new Ticket
                    {
                        IdProduit = planifEntrain.Id,
                        IdVersionProduit = pe11.Id,
                        IdOs = android.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 7, 6),
                        ResolutionDate = null,
                        DescriptionTexte = "L'utilisateur signale que l'application consomme beaucoup de batterie en arrière-plan sur Android, même quand aucune séance n'est en cours. Son téléphone perd environ 15% de batterie par heure alors que l'application n'est pas utilisée.",
                        ResolutionTexte = null
                    },
                    // Linux - En cours
                    new Ticket
                    {
                        IdProduit = planifEntrain.Id,
                        IdVersionProduit = pe11.Id,
                        IdOs = linux.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 7, 20),
                        ResolutionDate = null,
                        DescriptionTexte = "La fonctionnalité d'import de parcours GPS au format GPX ne fonctionne pas sous Linux. Un message d'erreur indique que le format n'est pas reconnu alors que le fichier est valide et s'ouvre correctement dans d'autres logiciels.",
                        ResolutionTexte = null
                    },
                    // Windows - Résolu
                    new Ticket
                    {
                        IdProduit = planifEntrain.Id,
                        IdVersionProduit = pe11.Id,
                        IdOs = windows.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 6, 29),
                        ResolutionDate = new DateOnly(2023, 7, 13),
                        DescriptionTexte = "Le calendrier de planification des séances affiche les mauvaises dates depuis le passage à l'heure d'été. Les séances apparaissent décalées d'une heure par rapport à leur heure réelle de programmation.",
                        ResolutionTexte = "La gestion des fuseaux horaires ne prenait pas en compte le passage à l'heure d'été. Les dates et heures sont désormais stockées en UTC dans la base de données et converties en heure locale uniquement à l'affichage."
                    },
                    // Windows Mobile - En cours
                    new Ticket
                    {
                        IdProduit = planifEntrain.Id,
                        IdVersionProduit = pe11.Id,
                        IdOs = windowsMobile.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 8, 3),
                        ResolutionDate = null,
                        DescriptionTexte = "Sur Windows Mobile, l'écran de suivi en temps réel d'une séance s'éteint après 30 secondes, même lorsque la séance est en cours. L'utilisateur doit constamment rallumer l'écran pour voir ses statistiques.",
                        ResolutionTexte = null
                    },

                    // --- Version 2.0 ---
                    // iOS - Résolu
                    new Ticket
                    {
                        IdProduit = planifEntrain.Id,
                        IdVersionProduit = pe20.Id,
                        IdOs = ios.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 7, 13),
                        ResolutionDate = new DateOnly(2023, 7, 27),
                        DescriptionTexte = "L'utilisateur ne reçoit pas les rappels de séance programmés sur iPhone. Il a vérifié que les notifications sont bien activées dans les paramètres iOS, mais aucune notification n'arrive aux heures prévues.",
                        ResolutionTexte = "Les rappels étaient planifiés avec un identifiant dupliqué, ce qui faisait que chaque nouveau rappel écrasait le précédent. La génération des identifiants de notifications locales a été corrigée pour garantir leur unicité."
                    },

                    // =============================================
                    // PLANIFICATEUR D'ANXIETE SOCIALE
                    // =============================================

                    // --- Version 1.0 ---
                    // iOS - En cours
                    new Ticket
                    {
                        IdProduit = planifAnxiete.Id,
                        IdVersionProduit = pa10.Id,
                        IdOs = ios.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 9, 14),
                        ResolutionDate = null,
                        DescriptionTexte = "L'exercice de respiration guidée se fige après quelques secondes. L'animation s'arrête mais le son continue. L'utilisateur doit fermer et rouvrir l'application pour retrouver un fonctionnement normal.",
                        ResolutionTexte = null
                    },
                    // Windows - Résolu (x2)
                    new Ticket
                    {
                        IdProduit = planifAnxiete.Id,
                        IdVersionProduit = pa10.Id,
                        IdOs = windows.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 9, 7),
                        ResolutionDate = new DateOnly(2023, 9, 21),
                        DescriptionTexte = "L'utilisateur signale que le journal de bord tronque son texte à partir d'un certain nombre de caractères. Ses entrées longues sont sauvegardées en partie seulement, et la fin de ses textes est perdue sans avertissement.",
                        ResolutionTexte = "Une limite de 500 caractères était appliquée côté client sans en informer l'utilisateur. La limite a été portée à 5000 caractères et un compteur visible a été ajouté pour que l'utilisateur sache combien de caractères il lui reste."
                    },
                    new Ticket
                    {
                        IdProduit = planifAnxiete.Id,
                        IdVersionProduit = pa10.Id,
                        IdOs = windows.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 10, 5),
                        ResolutionDate = new DateOnly(2023, 10, 19),
                        DescriptionTexte = "L'utilisateur ne peut pas modifier une entrée de journal déjà sauvegardée. Lorsqu'il clique sur une entrée pour l'éditer, le champ de texte est en lecture seule et ne permet pas la modification.",
                        ResolutionTexte = "Le mode édition n'était pas activé lors du clic sur une entrée existante à cause d'un oubli dans la logique d'état de l'interface. La correction a été déployée et l'utilisateur peut désormais modifier ses entrées sans difficulté."
                    },

                    // --- Version 1.1 ---
                    // MacOS - En cours
                    new Ticket
                    {
                        IdProduit = planifAnxiete.Id,
                        IdVersionProduit = pa11.Id,
                        IdOs = macos.Id,
                        IdStatut = enCours.Id,
                        CreationDate = new DateOnly(2023, 10, 26),
                        ResolutionDate = null,
                        DescriptionTexte = "Depuis la mise à jour vers la version 1.1, l'application demande les permissions de micro à chaque lancement sur MacOS, même si elles ont déjà été accordées lors de l'installation. C'est agaçant pour l'utilisateur.",
                        ResolutionTexte = null
                    },
                    // Windows - Résolu (x2)
                    new Ticket
                    {
                        IdProduit = planifAnxiete.Id,
                        IdVersionProduit = pa11.Id,
                        IdOs = windows.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 10, 19),
                        ResolutionDate = new DateOnly(2023, 11, 2),
                        DescriptionTexte = "Le rapport de progression mensuel en PDF généré par l'application est vide. Le fichier est créé, il s'ouvre, mais toutes les pages sont blanches. Aucune des données de progression n'est visible.",
                        ResolutionTexte = "Le moteur de génération PDF ne trouvait pas les ressources graphiques nécessaires sur certaines configurations Windows avec des restrictions de sécurité. La logique d'accès aux fichiers temporaires a été corrigée pour utiliser le dossier utilisateur courant, toujours accessible."
                    },
                    new Ticket
                    {
                        IdProduit = planifAnxiete.Id,
                        IdVersionProduit = pa11.Id,
                        IdOs = windows.Id,
                        IdStatut = resolu.Id,
                        CreationDate = new DateOnly(2023, 11, 16),
                        ResolutionDate = new DateOnly(2023, 11, 30),
                        DescriptionTexte = "Le graphique de suivi de l'humeur sur 30 jours s'affiche toujours vide même après plusieurs semaines d'utilisation régulière. L'utilisateur voit bien ses saisies quotidiennes dans le journal mais le graphique ne se remplit pas.",
                        ResolutionTexte = "Les données de suivi de l'humeur n'étaient pas correctement liées à l'utilisateur courant dans la requête d'agrégation. La requête a été corrigée pour filtrer par identifiant utilisateur avant l'affichage du graphique."
                    }
                );
                _context.SaveChanges();
            }
        }
    }
}

<Query Kind="Statements">
  <Connection>
    <ID>d4ad1079-3da6-4bf5-880f-d7d40febb245</ID>
    <NamingServiceVersion>3</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <UseMicrosoftDataSqlClient>true</UseMicrosoftDataSqlClient>
    <EncryptTraffic>true</EncryptTraffic>
    <Database>NexaWorksBackEnd</Database>
    <MapXmlToString>false</MapXmlToString>
    <DriverData>
      <SkipCertificateCheck>true</SkipCertificateCheck>
    </DriverData>
  </Connection>
  <IncludeLinqToSql>true</IncludeLinqToSql>
  <IncludeAspNet>true</IncludeAspNet>
  <RuntimeVersion>8.0</RuntimeVersion>
</Query>

//Requetes compatibles
//Obtenir tous les problèmes résolus (tous les produits)
//Obtenir tous les problèmes résolus pour un produit (toutes les versions)
//Obtenir tous les problèmes résolus pour un produit (une seule version)
//Obtenir tous les problèmes résolus au cours d’une période donnée pour un produit (toutes les versions)
//Obtenir tous les problèmes résolus au cours d’une période donnée pour un produit (une seule version)
//Obtenir tous les problèmes résolus contenant une liste de mots-clés (tous les produits)
//Obtenir tous les problèmes résolus pour un produit contenant une liste de mots-clés (toutes les versions)
//Obtenir tous les problèmes résolus pour un produit contenant une liste de mots-clés (une seule version)
//Obtenir tous les problèmes résolus au cours d’une période donnée pour un produit contenant une liste de mots-clés (toutes les versions)
//Obtenir tous les problèmes résolus au cours d’une période donnée pour un produit contenant une liste de mots-clés (une seule version)


int? produitId = null;
int? versionId = null;


// Fermeture
DateOnly? fermetureDateDebutPeriode = null;
DateOnly? fermetureDateFinPeriode = null;
string? fermetureMotCle = null;

// Normalisation des mots-clés AVANT la requête

string? fermetureMotCleNorm = fermetureMotCle?.ToLower();

var result = (from T in Tickets
              join VP in VersionProduits on T.IdVersionProduit equals VP.Id
              join P  in Produits        on T.IdProduit        equals P.Id
              join O  in OS              on T.IdOS             equals O.Id
              join S  in Statuts         on T.IdStatut         equals S.Id
              where S.Id == 2
              &&    (produitId == null || T.IdProduit == produitId)
              &&    (versionId == null || T.IdVersionProduit == versionId)

              &&    (fermetureDateDebutPeriode == null || T.ResolutionDate >= fermetureDateDebutPeriode)
              &&    (fermetureDateFinPeriode == null   || T.ResolutionDate <= fermetureDateFinPeriode)
              &&    (fermetureMotCleNorm == null || T.ResolutionTexte.ToLower().Contains(fermetureMotCleNorm))
              select new
              {
                  T.Id,
                  P.NomProduit,
                  O.NomOS,
                  VP.NomVersion,
                  S.NomStatut,
                  T.CreationDate,
                  T.ResolutionDate,
                  T.DescriptionTexte,
                  T.ResolutionTexte
              }).Dump();
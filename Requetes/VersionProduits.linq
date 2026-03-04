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
</Query>

var result = (from VP in VersionProduits
join P in Produits on VP.IdProduit equals P.Id
              select new
              {
			  VP.Id,
				  P.NomProduit,
				  VP.NomVersion,
              }).Dump();
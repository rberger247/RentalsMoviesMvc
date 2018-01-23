# RentalsMoviesMvc







### How To Implement AspNet Identity With Existing DataBase 

* Create Mvc Project 
* Run App and register User
* Create ado entity model and connect to existing DataBase
* In web Config file change Name of connection string for  Sql Client ,
  Change Initial Catalog of Entity Client to be the same as Sql Client and attach db file of existing db to entity client
    <add name="IdentityDbContext" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;
         AttachDbFilename=C:\Users\Rafib\ExistingDb.Mdf;Initial Catalog=ExistingDb;
         Integrated Security=True" providerName="System.Data.SqlClient" />
    <add name="RentalStoreEntities" connectionString="metadata=res://*/Models.RentalStoreModel.csdl|
         res://*/Models.RentalStoreModel.ssdl|res://*/Models.RentalStoreModel.msl;
         provider=System.Data.SqlClient;
         provider connection string=&quot;data source=(LocalDB)\MSSQLLocalDB;        
         initial catalog=RentalStore;
            AttachDbFilename=C:\Users\Rafib\ExistingDb.Mdf;
         integrated security=True;
         MultipleActiveResultSets=True;
         App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  *      Go to Identity Model.Cs and change DefaultConnection to sql Client Name(i.e IdentityDbContext) 
         
         ### Important Note
         * Name of Connection string for sql Client should be the same as the name referenced in ApplicationDbContext
         * e.g (in IdentityModel.Cs) public class ApplicationDbContext : IdentityDbContext
         This should match name of Connection String
          
         

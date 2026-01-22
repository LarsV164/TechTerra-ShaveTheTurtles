using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTerra_FrontEnd.DataBase.Data;

namespace TechTerra_FrontEnd.DataAccessLayer
{
    public class DAL
    {
        private readonly string connectionString;

        public DAL()
        {
            // 1. Conncetie bouwen voor Azure SQL Database
            // this.connectionString = BuildConnectionString();

            //2. Connectie bouwen voor lokale database
            this.connectionString = localConnectionString();
        }

        // Connection string maken voor  Azure SQL Database
        /*
        private string BuildConnectionString()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "sheve-the-turtles.database.windows.net",
                UserID = "ShaveTheTurtles",
                Password = "STT-123456",
                InitialCatalog = "Dierentuin"
            };

            return builder.ConnectionString;
        }
        */

        // Connection string maken voor lokale database

        // PAS DEZE AAN NAAR JOUW EIGEN INSTELLINGEN!!! (trust server certificate op true zetten anders werkt het niet en deze in de connectionstring aan elkaar vast typen VB: TrustServerCertificate=True)
        private string localConnectionString()
        {
            string connectionstring = "Data Source = ASUS_Lars; Initial Catalog = Dierentuin; Integrated Security = True; Encrypt = True; TrustServerCertificate = True";
            return connectionstring;
        }



        // Dieren ophalen uit de database
        public List<Dier> GetDieren()
        {
            var dieren = new List<Dier>();

            // Vraag de gebruiker om een sorteervolgorde
            Console.Clear();
            Console.WriteLine("Sorteer op:\n1. ID\n2. Soort\n3. Verblijf\n");
            Console.WriteLine("Selecteer een optie: ");
            string choice = Console.ReadLine();

            string queryString;

            switch (choice)
            {
                case "1":
                    queryString = @"
                SELECT d.ID, d.Naam, d.Soort, d.VerblijfID, v.Naam AS Verblijfnaam, d.Geboortedatum
                FROM tbl_Dier d
                INNER JOIN tbl_Verblijf v ON d.VerblijfID = v.ID
                ORDER BY d.ID";
                    break;
                case "2":
                    queryString = @"
                SELECT d.ID, d.Naam, d.Soort, d.VerblijfID, v.Naam AS Verblijfnaam, d.Geboortedatum
                FROM tbl_Dier d
                INNER JOIN tbl_Verblijf v ON d.VerblijfID = v.ID
                ORDER BY d.Soort";
                    break;
                case "3":
                    queryString = @"
                SELECT d.ID, d.Naam, d.Soort, d.VerblijfID, v.Naam AS Verblijfnaam, d.Geboortedatum
                FROM tbl_Dier d
                INNER JOIN tbl_Verblijf v ON d.VerblijfID = v.ID
                ORDER BY d.VerblijfID";  
                    break;
                default:
                    queryString = @"
                SELECT d.ID, d.Naam, d.Soort, d.VerblijfID, v.Naam AS Verblijfnaam, d.Geboortedatum
                FROM tbl_Dier d
                INNER JOIN tbl_Verblijf v ON d.VerblijfID = d.VerblijfID;";
                    break;
            }

            // Voer de query uit en vul de lijst met dieren
            using (var connection = new SqlConnection(connectionString))


            using (var command = new SqlCommand(queryString, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var dier = new Dier
                        
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("ID")),           // int
                            Naam = reader.GetString(reader.GetOrdinal("Naam")),  // string
                            Soort = reader.GetString(reader.GetOrdinal("Soort")), // string  
                            VerblijfID = reader.GetInt32(reader.GetOrdinal("VerblijfID")),  // int
                            VerblijfNaam = reader.GetString(reader.GetOrdinal("Verblijfnaam")), // string
                            Geboortedatum = reader.GetDateTime(reader.GetOrdinal("Geboortedatum")) // DateTime
                        };

                        
                        dieren.Add(dier);
                    }
                }
            }

            return dieren;
        }


    }
}

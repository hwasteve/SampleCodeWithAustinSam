using MyApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyFirstApi.Service
{
    public class StoreService
    {
        /// <summary>
        /// Get the list of stores we have in the database
        /// </summary>
        /// <returns></returns>
        public List<Store> GetStores()
        {

            List<Store> stores = new List<Store>();

            SqlConnection db = 
                new SqlConnection("Server=tcp:waldoserver.database.windows.net,1433;Initial Catalog=waldo;Persist Security Info=False;User ID=waldo;Password=1234@terp;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            db.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Store");
            cmd.Connection = db;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null)
            {
                Store s = null;

                while (reader.Read())
                {
                    s = new Store();
                    s.Name = reader["Name"].ToString();
                    stores.Add(s);
                }
            }


            //s = new Store();
            //s.Name = "Terp #2";
            //s.Street = "Baltimore Pike";
            //stores.Add(s);

            //s = new Store();
            //s.Name = "Turtle #3";
            //s.Street = "College Road";
            //stores.Add(s);

            //s = new Store();
            //s.Name = "Prince George #3";
            //s.Street = "CGI Road";
            //stores.Add(s);

            db.Close();

            return stores;
        }

        public Store GetStore(int StoreId)
        {
            SqlConnection db =
                new SqlConnection("Server=tcp:waldoserver.database.windows.net,1433;Initial Catalog=waldo;Persist Security Info=False;User ID=waldo;Password=1234@terp;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            db.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Store WHERE StoreId = @StoreId");
            cmd.Parameters.Add(new SqlParameter {ParameterName = "@StoreId",  DbType = System.Data.DbType.Int32, Value = StoreId });

            cmd.Connection = db;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null)
            {
                if (reader.Read())
                {
                    Store s = new Store();
                    s.Name = reader["Name"].ToString();

                    db.Close();
                    return s;
                }
            }

            db.Close();

            return null;
        }
    }
}

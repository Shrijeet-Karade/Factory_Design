using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp4
{
    class DBWriter : IRepository
    {
        
        public string GetDBType()
        {
            return "DBWriter";
        }

        public void Save(string id, int price, string typeOfProduct,bool save)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
                build.DataSource = "localHost";
                build.UserID = "sa";
                build.Password = "test123!@#";
                build.InitialCatalog = "Products";
                using (connection = new SqlConnection(build.ConnectionString))
                {
                    connection.Open();
                    String command = " Update " + typeOfProduct + " SET saved = '" + save + "' Where Name = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(command, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void Book(string id, int price, string typeOfProduct, bool book)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
                build.DataSource = "localHost";
                build.UserID = "sa";
                build.Password = "test123!@#";
                build.InitialCatalog = "Products";
                using (connection = new SqlConnection(build.ConnectionString))
                {
                    connection.Open();
                    String command = " Update " + typeOfProduct + " SET Booked = '" + book + "' Where Name = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(command,connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

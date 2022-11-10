using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using P05_KatmanliMimari.DataAccessLayer.Entities;

namespace P05_KatmanliMimari.DataAccessLayer
{
    public class SqliteMusteriDAL : IMusteriDAL
    {
        private SqliteConnection GetSqliteConnection()
        {
            string connectionString = "Data Source=northwind.db";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
            return sqliteConnection;
        }
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void CreateMusteri(Musteri musteri)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetAllMusteri()
        {
            List<Musteri> musteri = new List<Musteri>();
            using (var connection = GetSqliteConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "select CustomerId, CompanyName, ContactName, City from Customers ";
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        musteri.Add(new Musteri()
                        {
                            CustomerId = sqlDataReader[0].ToString(),
                            CompanyName = sqlDataReader["CompanyName"].ToString(),
                            ContactName = (sqlDataReader[2].ToString()),
                            City = (sqlDataReader[3].ToString())
                        });

                    }
                    sqlDataReader.Close();
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Bir sorun oluştu");
                }
                finally
                {
                    connection.Close();
                }
            }
            return musteri;

        }

        Musteri IMusteriDAL.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMusteri(Musteri musteri)
        {
            throw new NotImplementedException();
        }

        public void DeleteMusteri(int id)
        {
            throw new NotImplementedException();
        }

        List<Musteri> IMusteriDAL.GetAllProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}
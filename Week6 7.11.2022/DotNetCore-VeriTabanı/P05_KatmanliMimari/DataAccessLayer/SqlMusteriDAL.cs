using System.Data.SqlClient;
using P05_KatmanliMimari.DataAccessLayer.Entities;

namespace P05_KatmanliMimari.DataAccessLayer
{
    public class SqlMusteriDAL : IMusteriDAL
    {
        private SqlConnection GetSqlConnection()
            {
        //1.Adım = Connection string oluşturmak   @:kaçış işareti 
        string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS; Database=Northwind; User Id=sa; Password=123";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        return sqlConnection;
        }
        public void CreateMusteri(Musteri musteri)
        {
            throw new NotImplementedException();
        }

        public void DeleteMusteri(int id)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetAllMusteri()
        {
            List<Musteri> musteri = new List<Musteri>();
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "select CustomerId, CompanyName, ContactName, City from Customers";
                    SqlCommand sqlCommand = new SqlCommand(queryString,connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        musteri.Add(new Musteri(){
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

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMusteri(Musteri musteri)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetAllProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        Musteri IMusteriDAL.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
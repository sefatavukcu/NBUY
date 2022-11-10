using System.Data.SqlClient;
using P05_KatmanliMimari.DataAccessLayer.Entities;

namespace P05_KatmanliMimari.DataAccessLayer
{
    public class SqlProductDAL : IProductDAL
    {
        private SqlConnection GetSqlConnection()
            {
        //1.Adım = Connection string oluşturmak   @:kaçış işareti 
        string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS; Database=Northwind; User Id=sa; Password=123";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        return sqlConnection;
        }
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "select ProductId, ProductName, UnitPrice, UnitsInStock from Products ";
                    SqlCommand sqlCommand = new SqlCommand(queryString,connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        products.Add(new Product(){
                            Id = int.Parse(sqlDataReader[0].ToString()),
                            Name = sqlDataReader[1].ToString(),
                            Price = decimal.Parse(sqlDataReader[2].ToString()),
                            Stock = int.Parse(sqlDataReader[3].ToString())
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
            return products;
            
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}
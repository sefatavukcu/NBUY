using System.Data.SqlClient;

namespace P04_VeriErisimSinifi;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("1-Product List");
        System.Console.WriteLine("2-Customer List");
        int secim = int.Parse(Console.ReadLine());
        if (secim==1)
        {
            ProductList();
        }
        else if (secim==2)
        {
            CustomerList();
        }
        else
        {
            System.Console.WriteLine("gg");
        }

    }
    static void ProductList()
    {
        List<Product> products = GetAllProducts();
        foreach (var product in products)
        {
            System.Console.WriteLine($"Id: {product.Id} - Name: {product.Name} - Price: {product.Price} - Stock: {product.Stock}");
        }    
    }
        static void CustomerList()
    {
        List<Musteri> musteriler = GetAllCustomers();
        foreach (var musteri in musteriler)
        {
            System.Console.WriteLine($"Id: {musteri.CustomerId} - Company Name: {musteri.CompanyName} - Contact Name: {musteri.ContactName} - City: {musteri.City}");
        }   
    }

static List<Product> GetAllProducts()
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

























    static List<Musteri> GetAllCustomers()
    {
        List<Musteri> musteri = new List<Musteri>();
        using (var connection = GetSqlConnection())
        {
            try
            {
                connection.Open();
                string queryString = "select CustomerId, CompanyName, ContactName, City from Customers ";
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
    static SqlConnection GetSqlConnection()
    {
        //1.Adım = Connection string oluşturmak   @:kaçış işareti 
        string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS; Database=Northwind; User Id=sa; Password=123";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        return sqlConnection;
    }
}
using System.Data.SqlClient;

namespace P03_VerilerinNesneyleTasinması_musteri;
class Program
{
    static void Main(string[] args)
    {
        List<Musteri> musteriler = GetAllProducts();
        foreach (var musteri in musteriler)
        {
            System.Console.WriteLine($"Id: {musteri.CustomerId} - Company Name: {musteri.CompanyName} - Contact Name: {musteri.ContactName} - City: {musteri.City}");
        }        

    }
    static List<Musteri> GetAllProducts()
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
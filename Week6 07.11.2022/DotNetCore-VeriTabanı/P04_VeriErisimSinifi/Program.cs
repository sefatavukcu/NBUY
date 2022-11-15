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
            //CustomerList();
            Console.ReadLine();
        }
        else
        {
            System.Console.WriteLine("gg");
        }

    }
    static void ProductList()
    {
        // var sqlProductDAL = new SqlProductDAL();
        // List<Product> products = sqlProductDAL.GetAllProducts();
        var sqliteProductDAL = new SqliteProductDAL();
        List<Product> products = sqliteProductDAL.GetAllProducts();
        foreach (var product in products)
        {
            System.Console.WriteLine($"Id: {product.Id} - Name: {product.Name} - Price: {product.Price} - Stock: {product.Stock}");
        }    
    }
    //     static void CustomerList()
    // {
    //     List<Musteri> musteriler = GetAllCustomers();
    //     foreach (var musteri in musteriler)
    //     {
    //         System.Console.WriteLine($"Id: {musteri.CustomerId} - Company Name: {musteri.CompanyName} - Contact Name: {musteri.ContactName} - City: {musteri.City}");
    //     }   
    // }

    // static List<Musteri> GetAllCustomers()
    // {
    //     List<Musteri> musteri = new List<Musteri>();
    //     using (var connection = GetSqlConnection())
    //     {
    //         try
    //         {
    //             connection.Open();
    //             string queryString = "select CustomerId, CompanyName, ContactName, City from Customers ";
    //             SqlCommand sqlCommand = new SqlCommand(queryString,connection);
    //             SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
    //             while (sqlDataReader.Read())
    //             {
    //                 musteri.Add(new Musteri(){
    //                     CustomerId = sqlDataReader[0].ToString(),
    //                     CompanyName = sqlDataReader["CompanyName"].ToString(),
    //                     ContactName = (sqlDataReader[2].ToString()),
    //                     City = (sqlDataReader[3].ToString())
    //                 });

    //             }
    //             sqlDataReader.Close();
    //         }
    //         catch (Exception)
    //         {
    //             System.Console.WriteLine("Bir sorun oluştu");
    //         }
    //         finally
    //         {
    //             connection.Close();
    //         }
    //     }
    //     return musteri;
    // }
    

}
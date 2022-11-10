using System.Data.SqlClient;
using P05_KatmanliMimari.BusinessLayer;
using P05_KatmanliMimari.DataAccessLayer;
using P05_KatmanliMimari.DataAccessLayer.Entities;
namespace P05_KatmanliMimari;
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
        var productManager = new ProductManager(new SqliteProductDAL());
        List<Product> products = productManager.GetAllProducts();
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
     
    

}
using System.Data.SqlClient;
using P05_KatmanliMimari.BusinessLayer;
using P05_KatmanliMimari.DataAccessLayer;
using P05_KatmanliMimari.DataAccessLayer.Entities;
namespace P05_KatmanliMimari;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Choose Database");
        System.Console.WriteLine("1-MsSql");
        System.Console.WriteLine("2-Sqlite");
        int secim = int.Parse(Console.ReadLine());
        if (secim==1)
        {
            Menu(secim);
        }
        else if (secim==2)
        {
            Menu(secim);
        }
        else
        {
            System.Console.WriteLine("gg");
        }

    }

    static void Menu(int dbType)
    {
        Console.Clear();
        string dbName = dbType == 1 ? "MsSql" : "SqLite";
        System.Console.WriteLine($"By {dbName} Database - Northwind");
        System.Console.WriteLine("-------------------------------");
        System.Console.WriteLine("1-Product List");
        System.Console.WriteLine("2-Customer List");
        System.Console.Write("Seçiminizi yapınız:");
        int secim = int.Parse(Console.ReadLine());
        if (secim==1)
        {
            if (dbType==1)
            {
                ProductList(new SqlProductDAL());
            }
            else
            {
                ProductList(new SqliteProductDAL());
            }
        }
        else if (secim==2)
        {
            if (dbType==1)
            {
                MusteriList(new SqlMusteriDAL());
            }
            else
            {
                MusteriList(new SqliteMusteriDAL());
            }
        }
    }
    static void ProductList(IProductDAL productDAL)
    {
        var productManager = new ProductManager(productDAL);
        List<Product> products = productManager.GetAllProducts();
        foreach (var product in products)
        {
            System.Console.WriteLine($"Id: {product.Id} - Name: {product.Name} - Price: {product.Price} - Stock: {product.Stock}");
        }    
    }
        static void MusteriList(IMusteriDAL musteriDAL)
    {
        var musteriManager = new MusteriManager(musteriDAL);
        List<Musteri> musteriler = musteriManager.GetAllMusteri();
        foreach (var musteri in musteriler)
        {
            System.Console.WriteLine($"Customer Id: {musteri.CustomerId} - Company Name: {musteri.CompanyName} - Contact Name: {musteri.ContactName} - City: {musteri.City}");
        }      
    }
}
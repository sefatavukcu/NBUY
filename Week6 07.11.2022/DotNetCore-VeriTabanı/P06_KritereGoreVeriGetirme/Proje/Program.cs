using System.Data.SqlClient;
using Proje.BusinessLayer;
using Proje.DataAccessLayer;
using Proje.DataAccessLayer.Entities;
namespace Proje;
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
        if (dbType==1)
        {
            System.Console.WriteLine("3-Search Product By ID");
            System.Console.WriteLine("4-Filter product by category id");
            System.Console.WriteLine("5-Filter Product By Category Name");
        }
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
        else if (secim==3)
        {
            if (dbType==1)
            {
                ProductsSearch(new SqlProductDAL());
            }
            else
            {

            }
        }
        else if (secim==4)
        {
            if (dbType==1)
            {
                ProductsFilterByCategoryId(new SqlProductDAL());
            }
            else
            {
                
            }
        }
        else if (secim==5)
        {
            if (dbType==1)
            {
                ProductsFilterByCategoryName(new SqlProductDAL());
            }
            else
            {
                
            }
        }
    }

static void ProductsFilterByCategoryName(IProductDAL productDAL)
    {
        var productManager =new ProductManager(productDAL);
        System.Console.Write("Enter Category Name: ");
        string Name = Console.ReadLine();
        List<Product> products = productManager.GetAllProductByCategory(Name);
        if(products.Count>0)
        {
            foreach (var product in products)
            {
                System.Console.WriteLine($"Id: {product.Id} - Name: {product.Name} - Price: {product.Price} - Stock: {product.Stock}");
            }
        }
        else
        {
            System.Console.WriteLine("Aradığınız kategoride ürün yoktur!");
        }
         
    }




    static void ProductsFilterByCategoryId(IProductDAL productDAL)
    {
        var productManager =new ProductManager(productDAL);
        System.Console.Write("Enter Category Id: ");
        int catId = int.Parse(Console.ReadLine());
        List<Product> products = productManager.GetProductsByCategoryId(catId);
        if(products.Count>0)
        {
            foreach (var product in products)
            {
                System.Console.WriteLine($"Id: {product.Id} - Name: {product.Name} - Price: {product.Price} - Stock: {product.Stock}");
            }
        }
        else
        {
            System.Console.WriteLine("Aradığınız kategoride ürün yoktur!");
        }
         
    }
    static void ProductsSearch(IProductDAL productDAL)
    {
        var productManager = new ProductManager(productDAL);
        System.Console.Write("Enter Id: ");
        int id = int.Parse(Console.ReadLine());
        Product product = productManager.GetByIdProduct(id);
        if (product!=null)
        {
             System.Console.WriteLine($"Id: {product.Id} - Name: {product.Name} - Price: {product.Price} - Stock: {product.Stock}");
        }
        else
        {
            System.Console.WriteLine("No Product");
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
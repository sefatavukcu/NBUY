using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje01.efcore;

namespace Proje01
{
    class CustomerModel
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public int OrderCount { get; set; }
        public List<OrderModel> Orders { get; set; }         
    }
    class OrderModel
    {
        public int OrderId { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }
    }
    public class MultiTable
    {
        public void MusteriSayisi()
        {
            var context = new NorthwindContext();
            var result = context.Customers.Count();
            System.Console.WriteLine(result);
        }

        public void SatisYapilanMusteriler()
        {
            // Gelen listede her customere ait 
            // id, companyname, contact name, city
            var context = new NorthwindContext();
            var customers = context
                .Customers
                .Where(c=>c.Orders.Count()>0)
                .Select(c=>new CustomerModel(){
                    CustomerId=c.CustomerId,
                    CompanyName=c.CompanyName,
                    ContactName=c.ContactName,
                    City=c.City
                })
                .ToList();
            foreach (var c in customers)
            {
                System.Console.WriteLine(c.CustomerId + " --- " + c.CompanyName + " --- " + c.ContactName + " --- " + c.City);
            }
            System.Console.WriteLine(customers.Count);
        }

        public void SatisYapilmayanMusteriler()
        {
            // Gelen listede her customere ait 
            // id, companyname, contact name, city
            var context = new NorthwindContext();
            var customers = context
                .Customers
                .Where(c=>c.Orders.Count()==0)
                .Select(c=>new CustomerModel(){
                    CustomerId=c.CustomerId,
                    CompanyName=c.CompanyName,
                    ContactName=c.ContactName,
                    City=c.City
                })
                .ToList();
            foreach (var c in customers)
            {
                System.Console.WriteLine(c.CustomerId + " --- " + c.CompanyName + " --- " + c.ContactName + " --- " + c.City);
            }
            System.Console.WriteLine(customers.Count);
        }

        public void MusteriSatisListesi()
        {
            var context = new NorthwindContext();
            var customers = context
                .Customers
                .Select(c=> new CustomerModel(){
                    CustomerId=c.CustomerId,
                    CompanyName=c.CompanyName,
                    ContactName=c.ContactName,
                    City=c.City,
                    OrderCount=c.Orders.Count(),
                    Orders=c.Orders.Select(o=> new OrderModel(){
                        OrderId=o.OrderId,
                        ShippedDate=o.ShippedDate,
                        Freight=o.Freight
                    }).ToList()
            }).ToList();
            foreach (var c in customers)
            {
                System.Console.WriteLine(c.CustomerId + " --- " + c.CompanyName + " --- " + c.OrderCount);
                foreach (var o in c.Orders)
                {
                    System.Console.WriteLine("\t" + o.OrderId + " --- "+ o.ShippedDate + " --- " +o.Freight);
                }
                System.Console.WriteLine();
                
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Entity.Abstract;

namespace ShoppingApp.Entity.Concrete
{
    public class Product : IEntityBase
    {
        // Productların sahip olduğu özellikler
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; } // (?) nullable yapar, ürünün fiyatı 0 olma ihitmaline karşı vs
        public string Description { get; set; }
        public string ImageUrl { get; set; } // Resmin url bilgisi
        public string Url { get; set; }
        public bool IsHome { get; set; } // Anasayfa ürünü mü değil mi
        public bool IsApproved { get; set; }  // Onaylı ürün mü değil mi
        public DateTime DateAdded { get; set; } // Eklenme tarihi
        public List<ProductCategory> ProductCategories { get; set; } // birden fazla ürün tutabilmek için tanımlandı
    }
}
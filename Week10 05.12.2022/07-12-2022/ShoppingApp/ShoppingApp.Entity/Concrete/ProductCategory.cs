using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Entity.Concrete
{
    public class ProductCategory
    {
        // Hangi ürün hangi kategoriden olanlar için tanımlamalar
        // Çoka Çok bir tablo olacak, bir ürün birden fazla kategoriye, bir kategoriye birden fazla ürüne sahip olacak
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
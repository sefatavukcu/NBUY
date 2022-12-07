using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Entity.Abstract;

namespace ShoppingApp.Entity.Concrete
{
    public class Category : IEntityBase  //
    {
        // Categorylerin sahip olduğu özellikler
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<ProductCategory> ProductCategories { get; set; } // Bir kategoride birden fazla ürün tutabilmek için tanımladık

    }
}
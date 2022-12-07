using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Config;
using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Data.Concrete.EfCore.Contexts
{
    public class ShopAppContext :DbContext
    {
        public DbSet<Category> Categories { get; set; } //Category entitysinden veritabanına propları oluşturmak için  Categories adında tablo oluşturuldu.
        public DbSet<Product> Products { get; set; }  // Product entitysinden veritabanında Product tablosunu oluşturmak için bunu oluşturduk
        public DbSet<ProductCategory> ProductCategories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ShoppingApp.db"); // Database sqlite oluşturmak için ismi verildi.
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
            // Configuration'larımızı uygulayacağız.
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
        }
    }
}
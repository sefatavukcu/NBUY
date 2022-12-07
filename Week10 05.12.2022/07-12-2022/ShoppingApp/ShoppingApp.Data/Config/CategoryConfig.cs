using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // oluşacak olan veritababnında olması gereknleri yazıyoruz.
            builder.HasKey(c=>c.Id); // Primary Key burası olacak.
            builder.Property(c=>c.Id).ValueGeneratedOnAdd(); //

            builder.Property(c=>c.Name).IsRequired().HasMaxLength(50); // oluşacak olan veritabanında name ve max 50 karakter olmak zorunda
            builder.Property(c=>c.Description).IsRequired().HasMaxLength(500);
            builder.Property(c=>c.Url).IsRequired().HasMaxLength(250);

            builder.ToTable("Categories");  // Veritabanında oluşacak tablonun hangi isimde oluşacağı

            builder.HasData(
                new Category
                {
                    Id=1,
                    Name="Telefon",
                    Description="Telefonlar bu kategoride bulunmaktadır.",
                    Url="telefon"
                },
                new Category
                {
                    Id=2,
                    Name="Elektronik",
                    Description="Elektronik ürünler bu kategoride bulunmaktadır.",
                    Url="elektronik"
                },
                new Category
                {
                    Id=3,
                    Name="Bilgisayar",
                    Description="Bilgisayarlar bu kategoride bulunmaktadır.",
                    Url="bilgisayar"
                },
                new Category
                {
                    Id=4,
                    Name="Beyaz Eşya",
                    Description="Beyaz Eşyalar bu kategoride bulunmaktadır.",
                    Url="beyaz-esya"
                }
            );
        }
    }
}
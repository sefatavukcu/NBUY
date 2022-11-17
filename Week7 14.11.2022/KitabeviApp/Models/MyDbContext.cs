using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace KitabeviApp.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Kitabevi.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category() { Id = 1, Name = "Çocuk", Desc = "Çocuk Bookları" },
                    new Category() { Id = 2, Name = "Edebiyat", Desc = "Roman, Hikaye, Şiir Bookları" },
                    new Category() { Id = 3, Name = "Bilgisayar", Desc = "Bilgisayar Bookları" },
                    new Category() { Id = 4, Name = "AkNameemik", Desc = "AkNameemik Booklar" }
                );

            modelBuilder.Entity<Author>()
                .HasData(
                    new Author() { Id = 1, Name = "Matt Heig", BirthYear = 1980, Gender = 'E' },
                    new Author() { Id = 2, Name = "Feyyaz Yiğit", BirthYear = 1990, Gender = 'E' },
                    new Author() { Id = 3, Name = "Gizem Doğan", BirthYear = 1960, Gender = 'K' },
                    new Author() { Id = 4, Name = "Jack London", BirthYear = 1930, Gender = 'E' },
                    new Author() { Id = 5, Name = "Margaret Atwood", BirthYear = 1980, Gender = 'K' },
                    new Author() { Id = 6, Name = "Cem Akaş", BirthYear = 1980, Gender = 'E' },
                    new Author() { Id = 7, Name = "Zafer Demirkol", BirthYear = 1980, Gender = 'E' },
                    new Author() { Id = 8, Name = "İlber Ortaylı", BirthYear = 1980, Gender = 'E' },
                    new Author() { Id = 9, Name = "Seda Yiğit", BirthYear = 1980, Gender = 'K' },
                    new Author() { Id = 10, Name = "George Orwell", BirthYear = 1980, Gender = 'E' }
                );
            modelBuilder.Entity<Book>()
                .HasData(
                    new Book() { Id = 1, Name = "İnsanlar", WriteYear = 2021, PageNumber = 330, CategoryId = 2, AuthorId = 1 },
                    new Book() { Id = 2, Name = "Zamanı Durdurmanın Yolları", WriteYear = 2021, PageNumber = 370, CategoryId = 1, AuthorId = 1 },
                    new Book() { Id = 3, Name = "Demir Ökçe", WriteYear = 2017, PageNumber = 400, CategoryId = 2, AuthorId = 4 },
                    new Book() { Id = 4, Name = "Huzursuzluk", WriteYear = 2018, PageNumber = 330, CategoryId = 2, AuthorId = 9 },
                    new Book() { Id = 5, Name = "SerenName", WriteYear = 2020, PageNumber = 300, CategoryId = 2, AuthorId = 9 },
                    new Book() { Id = 6, Name = "19", WriteYear = 2016, PageNumber = 380, CategoryId = 2, AuthorId = 6 },
                    new Book() { Id = 7, Name = "C# Programlama Dili", WriteYear = 2011, PageNumber = 730, CategoryId = 3, AuthorId = 7 },
                    new Book() { Id = 8, Name = "React Uygulama Geliştirme", WriteYear = 2021, PageNumber = 530, CategoryId = 3, AuthorId = 3 },
                    new Book() { Id = 9, Name = "İnsan Ömrünü Neyle Geçirmeli?", WriteYear = 2021, PageNumber = 330, CategoryId = 2, AuthorId = 8 }
                );
        }
    }
}
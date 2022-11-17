﻿// <auto-generated />
using KitabeviApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KitabeviApp.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("KitabeviApp.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BirthYear")
                        .HasColumnType("INTEGER");

                    b.Property<char>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthYear = 1980,
                            Gender = 'E',
                            Name = "Matt Heig"
                        },
                        new
                        {
                            Id = 2,
                            BirthYear = 1990,
                            Gender = 'E',
                            Name = "Feyyaz Yiğit"
                        },
                        new
                        {
                            Id = 3,
                            BirthYear = 1960,
                            Gender = 'K',
                            Name = "Gizem Doğan"
                        },
                        new
                        {
                            Id = 4,
                            BirthYear = 1930,
                            Gender = 'E',
                            Name = "Jack London"
                        },
                        new
                        {
                            Id = 5,
                            BirthYear = 1980,
                            Gender = 'K',
                            Name = "Margaret Atwood"
                        },
                        new
                        {
                            Id = 6,
                            BirthYear = 1980,
                            Gender = 'E',
                            Name = "Cem Akaş"
                        },
                        new
                        {
                            Id = 7,
                            BirthYear = 1980,
                            Gender = 'E',
                            Name = "Zafer Demirkol"
                        },
                        new
                        {
                            Id = 8,
                            BirthYear = 1980,
                            Gender = 'E',
                            Name = "İlber Ortaylı"
                        },
                        new
                        {
                            Id = 9,
                            BirthYear = 1980,
                            Gender = 'K',
                            Name = "Seda Yiğit"
                        },
                        new
                        {
                            Id = 10,
                            BirthYear = 1980,
                            Gender = 'E',
                            Name = "George Orwell"
                        });
                });

            modelBuilder.Entity("KitabeviApp.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PageNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WriteYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CategoryId = 2,
                            Name = "İnsanlar",
                            PageNumber = 330,
                            WriteYear = 2021
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            CategoryId = 1,
                            Name = "Zamanı Durdurmanın Yolları",
                            PageNumber = 370,
                            WriteYear = 2021
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 4,
                            CategoryId = 2,
                            Name = "Demir Ökçe",
                            PageNumber = 400,
                            WriteYear = 2017
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 9,
                            CategoryId = 2,
                            Name = "Huzursuzluk",
                            PageNumber = 330,
                            WriteYear = 2018
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 9,
                            CategoryId = 2,
                            Name = "SerenName",
                            PageNumber = 300,
                            WriteYear = 2020
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 6,
                            CategoryId = 2,
                            Name = "19",
                            PageNumber = 380,
                            WriteYear = 2016
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 7,
                            CategoryId = 3,
                            Name = "C# Programlama Dili",
                            PageNumber = 730,
                            WriteYear = 2011
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 3,
                            CategoryId = 3,
                            Name = "React Uygulama Geliştirme",
                            PageNumber = 530,
                            WriteYear = 2021
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 8,
                            CategoryId = 2,
                            Name = "İnsan Ömrünü Neyle Geçirmeli?",
                            PageNumber = 330,
                            WriteYear = 2021
                        });
                });

            modelBuilder.Entity("KitabeviApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Desc = "Çocuk Bookları",
                            Name = "Çocuk"
                        },
                        new
                        {
                            Id = 2,
                            Desc = "Roman, Hikaye, Şiir Bookları",
                            Name = "Edebiyat"
                        },
                        new
                        {
                            Id = 3,
                            Desc = "Bilgisayar Bookları",
                            Name = "Bilgisayar"
                        },
                        new
                        {
                            Id = 4,
                            Desc = "AkNameemik Booklar",
                            Name = "AkNameemik"
                        });
                });

            modelBuilder.Entity("KitabeviApp.Models.Book", b =>
                {
                    b.HasOne("KitabeviApp.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitabeviApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

// <auto-generated />
using System;
using BlogApp.Data.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogApp.Data.Migrations
{
    [DbContext(typeof(BlogAppContext))]
    [Migration("20221128145748_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogApp.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5658),
                            Date = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5655),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5659),
                            Note = "C# 11.0 Yenilikleri",
                            SeoAuthor = "Deniz Gezen",
                            SeoDescription = "C# 11.0 Yenilikleri",
                            SeoTags = "C#, C# 11.0, DotNet 6, DotNet 7, DotNet Core",
                            Thumbnail = "default.jpg",
                            Title = "C# 11.0 Yenilikleri",
                            UserId = 1,
                            ViewsCount = 116
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5665),
                            Date = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5664),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5666),
                            Note = "Modern Javascript",
                            SeoAuthor = "Deniz Gezen",
                            SeoDescription = "Modern Javascript",
                            SeoTags = "ECMA Script, map, filter, reduce, arrow, function",
                            Thumbnail = "default.jpg",
                            Title = "Modern Javascript",
                            UserId = 1,
                            ViewsCount = 193
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.",
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5672),
                            Date = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5671),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(5673),
                            Note = "React Component Yapısı",
                            SeoAuthor = "Yusuf Onan",
                            SeoDescription = "React Component Yapısı",
                            SeoTags = "React, React Js, component, class component, function component",
                            Thumbnail = "default.jpg",
                            Title = "React Component Yapısı",
                            UserId = 2,
                            ViewsCount = 225
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7857),
                            Description = "C# programlama dili ile ilgili makaleler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7858),
                            Name = "C#",
                            Note = "C# kategorisi."
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7862),
                            Description = "Javascript programlama dili ile ilgili makaleler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7863),
                            Name = "Javascript",
                            Note = "Javascript kategorisi."
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7867),
                            Description = "React Js programlama dili ile ilgili makaleler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 444, DateTimeKind.Local).AddTicks(7868),
                            Name = "React Js",
                            Note = "React Js kategorisi."
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1154),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1156),
                            Note = "C# 11.0 yenilikleri ile ilgili yorum.",
                            Text = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham."
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1160),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1161),
                            Note = "Modern Javascript ile ilgili yorum.",
                            Text = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham."
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1164),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(1165),
                            Note = "React ile ilgili yorum.",
                            Text = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham."
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(2865),
                            Description = "admin rolü tüm haklara sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(2866),
                            Name = "Admin",
                            Note = "Bu, admin rolüdür."
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(2870),
                            Description = "user rolü tüm haklara sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(2871),
                            Name = "User",
                            Note = "Bu, user rolüdür."
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(7564),
                            Description = "İlk admin kullanıcısı",
                            Email = "denizgezen@gmail.com",
                            FirstName = "Deniz",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Gezen",
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(7565),
                            Note = "Admin kullanıcısı.",
                            PasswordHash = new byte[] { 50, 48, 48, 56, 50, 48, 101, 51, 50, 50, 55, 56, 49, 53, 101, 100, 49, 55, 53, 54, 97, 54, 98, 53, 51, 49, 101, 55, 101, 48, 100, 50 },
                            Picture = "https://www.teknozum.com/wp-content/uploads/2019/12/whatsapp-profil-foto%C4%9Fraflar%C4%B1-17-1024x1024.jpg",
                            RoleId = 1,
                            UserName = "denizgezen"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreated",
                            CreatedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(7588),
                            Description = "İlk user kullanıcısı",
                            Email = "yusufonan@gmail.com",
                            FirstName = "Yusuf",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Onan",
                            ModifiedByName = "InitialCreated",
                            ModifiedDate = new DateTime(2022, 11, 28, 17, 57, 48, 445, DateTimeKind.Local).AddTicks(7589),
                            Note = "User kullanıcısı.",
                            PasswordHash = new byte[] { 52, 54, 102, 57, 52, 99, 56, 100, 101, 49, 52, 102, 98, 51, 54, 54, 56, 48, 56, 53, 48, 55, 54, 56, 102, 102, 49, 98, 55, 102, 50, 97 },
                            Picture = "https://tasarimfikir.com/wp-content/uploads/profil-fotografi-tasarimi-min.jpg",
                            RoleId = 2,
                            UserName = "yusufonan"
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Article", b =>
                {
                    b.HasOne("BlogApp.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogApp.Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("BlogApp.Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.User", b =>
                {
                    b.HasOne("BlogApp.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}

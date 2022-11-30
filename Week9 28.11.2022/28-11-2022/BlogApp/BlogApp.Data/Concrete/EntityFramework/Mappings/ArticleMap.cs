using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            #region Açıklama
            //Burada EfCore tarafından default concention yöntemiyle kendiliğinden gerçekleşen bazı ayarları eli ile yapacağız. 
            // Bu daha profesyonel, sürdürülebilir, genişletebilir uygulamalar yapmak için tercih edilen bir yoldur.
            #endregion
            builder.HasKey(a => a.Id); //Primary Key
            builder.Property(a=>a.Id).ValueGeneratedOnAdd(); // Identity eklendikçe, birer birer artış. 

            builder.Property(a=>a.Title).IsRequired(); // zorunlu, varsayılanı true yani zorunlu
            builder.Property(a=>a.Title).HasMaxLength(100); // max 100 karakter (nvarchar 100 karakter gibi)

            builder.Property(a=>a.Content).IsRequired(); 
            builder.Property(a=>a.Content).HasColumnType("NVARCHAR(MAX)");

            builder.Property(a=>a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);

            builder.Property(a=>a.Date).IsRequired();

            builder.Property(a=>a.SeoAuthor).IsRequired();
            builder.Property(a=>a.SeoAuthor).HasMaxLength(50);

            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoDescription).HasMaxLength(150);

            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);

            builder.Property(a => a.ViewsCount).IsRequired();

            builder.Property(a => a.CommentCount).IsRequired();

            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);

            builder.Property(a => a.CreatedDate).IsRequired();

            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);

            builder.Property(a => a.ModifiedDate).IsRequired();

            builder.Property(a=>a.IsActive).IsRequired();

            builder.Property(a=>a.Note).HasMaxLength(500);

            builder.HasOne(c => c.Category)
                .WithMany(a=>a.Articles)
                .HasForeignKey(a=>a.CategoryId); // ilişkinin bire çok olan kısım category tek kısım, articles çok kısım

            builder.HasOne(u => u.User)
                .WithMany(a => a.Articles)
                .HasForeignKey(a => a.UserId);

            builder.ToTable("Articles");  // tabloda isin vermek için.

            // Article verilerinin eklenmesi

            builder.HasData(
                new Article
                {
                    Id= 1,
                    CategoryId= 1,
                    UserId= 1,
                    Title= "C# 11.0 Yenilikleri",
                    Content= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Thumbnail="default.jpg",
                    SeoDescription= "C# 11.0 Yenilikleri",
                    SeoTags="C#, C# 11.0, DotNet 6, DotNet 7, DotNet Core",
                    SeoAuthor="Deniz Gezen",
                    ViewsCount=116,
                    CommentCount=1,
                    Date=DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreated",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 11.0 Yenilikleri"
                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    UserId = 1,
                    Title = "Modern Javascript",
                    Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    Thumbnail = "default.jpg",
                    SeoDescription = "Modern Javascript",
                    SeoTags = "ECMA Script, map, filter, reduce, arrow, function",
                    SeoAuthor = "Deniz Gezen",
                    ViewsCount = 193,
                    CommentCount = 1,
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreated",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "Modern Javascript"
                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    UserId = 2,
                    Title = "React Component Yapısı",
                    Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "React Component Yapısı",
                    SeoTags = "React, React Js, component, class component, function component",
                    SeoAuthor = "Yusuf Onan",
                    ViewsCount = 225,
                    CommentCount = 1,
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreated",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "React Component Yapısı"
                }
                );
        }
    }
}

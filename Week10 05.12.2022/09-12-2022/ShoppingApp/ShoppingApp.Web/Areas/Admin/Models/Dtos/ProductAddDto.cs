using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class ProductAddDto
    {
        [DisplayName("Ürün Adı")]
        [Required(ErrorMessage ="{0} boş bırakılmamalıdır.")]
        [MinLength(5,ErrorMessage =("{0}, {1} karakter uzunluğunda olmalıdır."))]
        [MaxLength(50,ErrorMessage =("{0}, {1} karakter uzunluğunda olmalıdır."))]
        public string Name { get; set; }

        [DisplayName("Ürün Fiyatı")]
        [Required(ErrorMessage ="{0} boş bırakılmamalıdır.")]
        public decimal? Price { get; set; }

        [DisplayName("Ürün Açıklaması")]
        [Required(ErrorMessage ="{0} boş bırakılmamalıdır.")]
        [MinLength(5,ErrorMessage =("{0}, {1} karakter uzunluğunda olmalıdır."))]
        [MaxLength(50,ErrorMessage =("{0}, {1} karakter uzunluğunda olmalıdır."))]
        public string Description { get; set; }

        [DisplayName("Ürün Resmi")]
        [Required(ErrorMessage ="{0} boş bırakılmamalıdır.")]
        public IFormFile ImageFile { get; set; } // Sunucuya dosya yükleme

        [DisplayName("Ana Sayfa ürünü mü?")]
        public bool IsHome { get; set; }

        [DisplayName("Onaylı ürün mü?")]
        public bool IsApproved { get; set; }

        [DisplayName("Kategoriler")]
        public List<Category> Categories { get; set; }

        [Required(ErrorMessage ="En az bir kategori seçilmelidir.")]
        public List<Category> SelectedCategories { get; set; }
    }
}
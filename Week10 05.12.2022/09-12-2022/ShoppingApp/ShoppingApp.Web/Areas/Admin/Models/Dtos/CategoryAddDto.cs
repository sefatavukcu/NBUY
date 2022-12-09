using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Web.Models.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage ="{0} boş bırakılmamalıdır.")]
        [MinLength(5,ErrorMessage =("{0}, {1} karakter uzunluğunda olmalıdır."))]
        [MaxLength(50,ErrorMessage =("{0}, {1} karakter uzunluğunda olmalıdır."))]
        public string Name { get; set; }    
        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage ="{0} boş bırakılmamalıdır.")]
        [MinLength(10,ErrorMessage =("{0}, {1} karakter uzunluğunda olmalıdır."))]
        [MaxLength(500,ErrorMessage =("{0}, {1} karakter uzunluğunda olmalıdır."))]
        public string Description { get; set; }
        
    }
}
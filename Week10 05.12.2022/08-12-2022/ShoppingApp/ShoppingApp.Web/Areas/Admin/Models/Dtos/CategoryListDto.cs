using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class CategoryListDto
    {
        public List<Category> Categories { get; set; }
    }
}
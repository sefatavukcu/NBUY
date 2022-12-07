using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        // interface de olduğumuz için implemente gerek yok.
        // Producta özgü memberler burada olacak. (Property, field, method...) örneğin aşağıdakiler gibi....
        Category GetByIdWithProducts();
    }
}
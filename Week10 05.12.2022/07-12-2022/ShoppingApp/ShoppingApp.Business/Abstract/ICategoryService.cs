using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Business.Abstract
{
    public interface ICategoryService
    {
        // bütün generic metotları ve categorye özgü olan metotları buraya yazmalıyız.
        Task<Category> GetByIdAsync(int id);
        Task<List<Category>> GetAllAsync();
        Task CreateAsync(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetByIdWithProducts();
    }
}
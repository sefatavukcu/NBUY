using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje.DataAccessLayer;
using Proje.DataAccessLayer.Entities;

namespace Proje.BusinessLayer
{
    public class ProductManager
    {
        private readonly IProductDAL _productDAL;      // dependency injection
        public ProductManager(IProductDAL productDAL)  // dependency injection
        {
            _productDAL = productDAL;                  // dependency injection
        }
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProductByCategory(string categoryName)
        {
            return _productDAL.GetAllProductByCategory(categoryName);
            
        }

        public List<Product> GetAllProducts()
        {
            return _productDAL.GetAll();
        }

        public Product GetByIdProduct(int id)
        {
            return _productDAL.GetById(id);
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetProductsByCategoryId(int id)
        {
            return _productDAL.GetProductsByCategoryId(id);
        }
    }
    
}
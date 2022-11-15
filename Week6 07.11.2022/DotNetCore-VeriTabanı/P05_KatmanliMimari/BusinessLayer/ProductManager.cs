using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P05_KatmanliMimari.DataAccessLayer;
using P05_KatmanliMimari.DataAccessLayer.Entities;

namespace P05_KatmanliMimari.BusinessLayer
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
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            return _productDAL.GetAllProducts();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
    
}
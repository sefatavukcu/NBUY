using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P04_VeriErisimSinifi
{
    public interface IProductDAL
    {
        void CreateProduct(Product product);    // C-reate 
        List<Product> GetAllProducts();         // R-ead
        Product GetById(int id);         
        void UpdateProduct(Product product);    // U-pdate
        void DeleteProduct(int id);             // D-elete
    }
    public class SqlProductDAL : IProductDAL
    {
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using P05_KatmanliMimari.DataAccessLayer.Entities;

namespace P05_KatmanliMimari.DataAccessLayer
{
    public interface IProductDAL
    {
        void CreateProduct(Product product);    // C-reate 
        List<Product> GetAllProducts();         // R-ead
        Product GetById(int id);         
        void UpdateProduct(Product product);    // U-pdate
        void DeleteProduct(int id);             // D-elete
        List<Product> GetAllProductByCategory(string categoryName);
    }
}
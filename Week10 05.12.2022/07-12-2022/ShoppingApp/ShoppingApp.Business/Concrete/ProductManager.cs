using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Generic
        public async Task CreateAsync(Product product)
        {
            await _unitOfWork.Products.CreateAsync(product);
            await _unitOfWork.SaveAsync();
        }

        public void Delete(Product product)
        {
            _unitOfWork.Products.Delete(product);
            _unitOfWork.Save();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public void Update(Product product)
        {
            _unitOfWork.Products.Update(product);
            _unitOfWork.Save();
        }
        #endregion

        #region Products
        public List<Product> GetHomePageProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }
        #endregion

        
    }
}
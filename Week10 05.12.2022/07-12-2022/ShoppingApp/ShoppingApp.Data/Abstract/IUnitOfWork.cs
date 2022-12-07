using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; } //her bir oluşturulacak olan category ve productların nesneleri olacak.
        IProductRepository Products { get; }
        Task SaveAsync();
        void Save();
    }
}
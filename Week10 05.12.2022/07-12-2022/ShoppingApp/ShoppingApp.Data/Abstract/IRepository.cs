using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IRepository<T>
    {
        // generic genel tüm entitylerde geçerli olmasını istediğimiz imzaları atıyoruz.
        
        Task<T> GetByIdAsync(int id); // asenkron yapıyoruz. Id ye göre entity getirecek
        Task<List<T>> GetAllAsync(); // entity ile İlgili tüm kayıtları getirecek.
        Task CreateAsync(T entity);  // yeni kayıt yaratacak T olarak ne yollanırsa
        void Update(T entity);  // kayıt güncelleyecek T olarak ne yollanırsa
        void Delete(T entity);  // kayıt silecek. T olarak ne yollanırsa

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        // generic bir yapıya context yollamamız gerekiyor.
        public EfCoreCategoryRepository(ShopAppContext context) : base(context)
        {
            // buraya gelen context base classa gönderiliyor ve aynı zamanda sadece bu constructor içinde geçerli.
            // Ama bu classın bütününde henüz kullanılamıyor. Eğer kullanılsın istersek yapmamız gereken işlemler var.
        }

        public Category GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Entity.Abstract
{
    public interface IEntityBase // Burada tüm kullanılacak ortak interfaceler olacak.
    {
        public int Id { get; set; }
    }
}
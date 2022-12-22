using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    internal interface ICardItemRepository : IRepository<CardItem>
    {
        Task ChangeQuantity(CardItem cardItem, int quantity);
    }
}

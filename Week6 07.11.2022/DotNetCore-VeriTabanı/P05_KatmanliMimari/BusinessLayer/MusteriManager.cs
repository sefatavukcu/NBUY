using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P05_KatmanliMimari.DataAccessLayer;
using P05_KatmanliMimari.DataAccessLayer.Entities;

namespace P05_KatmanliMimari.BusinessLayer
{
    public class MusteriManager
    {
        private readonly IMusteriDAL _musteriDAL;      // dependency injection
        public MusteriManager(IMusteriDAL musteriDAL)  // dependency injection
        {
            _musteriDAL = musteriDAL;                  // dependency injection
        }
        public void CreateMusteri(Musteri musteri)
        {
            throw new NotImplementedException();
        }

        public void DeleteMusteri(int id)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetAllProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetAllMusteri()
        {
            return _musteriDAL.GetAllMusteri();
        }

        public Musteri GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMusteri(Musteri musteri)
        {
            throw new NotImplementedException();
        }
    }
    
}
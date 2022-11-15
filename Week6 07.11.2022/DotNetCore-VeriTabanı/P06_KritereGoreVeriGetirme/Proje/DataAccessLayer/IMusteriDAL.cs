using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Proje.DataAccessLayer.Entities;

namespace Proje.DataAccessLayer
{
    public interface IMusteriDAL
    {
        void CreateMusteri(Musteri musteri);    // C-reate 
        List<Musteri> GetAllMusteri();         // R-ead
        Musteri GetById(int id);         
        void UpdateMusteri(Musteri musteri);    // U-pdate
        void DeleteMusteri(int id);             // D-elete
        List<Musteri> GetAllProductByCategory(string categoryName);
    }
}
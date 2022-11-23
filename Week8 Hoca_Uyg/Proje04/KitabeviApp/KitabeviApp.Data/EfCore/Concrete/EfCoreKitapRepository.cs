using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Data.EfCore.Abstract;
using KitabeviApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace KitabeviApp.Data.EfCore.Concrete
{
    public class EfCoreKitapRepository : IKitapRepository
    {
        public void KitapEkle(Kitap kitap)
        {
            using (var context = new KitabeviContext())
            {
                context.Kitaplar.Add(kitap);
                context.SaveChanges();
            }
        }

        public void KitapGuncelle(Kitap kitap)
        {
            using (var context = new KitabeviContext())
            {
                context.Kitaplar.Update(kitap);
                context.SaveChanges();
            }
        }

        public List<Kitap> KitapListele(int? id = null)
        {
            using (var context = new KitabeviContext())
            {
                if (id == null)
                {
                    return context
                        .Kitaplar
                        .Include(k => k.Kategori)
                        .Include(k => k.Yazar)
                        .ToList();
                }
                else
                {
                    return context
                        .Kitaplar
                        .Where(c => c.KategoriId == id)
                        .Include(k => k.Kategori)
                        .Include(k => k.Yazar)
                        .ToList();
                }
            }
        }

        public void KitapSil(Kitap kitap)
        {
            using (var context = new KitabeviContext())
            {
                context.Kitaplar.Remove(kitap);
                context.SaveChanges();
            }
        }
    }
}
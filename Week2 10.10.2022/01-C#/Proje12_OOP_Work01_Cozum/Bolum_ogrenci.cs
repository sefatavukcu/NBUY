using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje12_OOP_Work01_Cozum
{
    interface IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    class Bolum : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
    }
    class Ogrenci : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
    }
}

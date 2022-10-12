using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje12_OOP_Work01
{
    public interface IBolum
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Ogrenci> ProduOgrencilercts { get; set; }
    }
    public class Aciklama:IBolum
    {
        public string aciklama { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Ad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Ogrenci> ProduOgrencilercts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class Ogrenci:IBolum
    {
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Ad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Ogrenci> ProduOgrencilercts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

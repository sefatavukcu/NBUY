namespace Proje12_OOP_Work01_Cozum
{
    internal class Program
    {
        static string GirisYap(string baslik)
        {
            Console.Write(baslik);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<Bolum> bolumler = new List<Bolum>();
            

            for (int i = 0; i < 2; i++)
            {
                Bolum bolum = new Bolum();
                Console.Write($"{i+1}. Bölüm Id giriniz:");
                bolum.Id = int.Parse(Console.ReadLine());
                Console.Write($"{i+1}. Bölümün adı:");
                bolum.Ad = Console.ReadLine();
                Console.Write($"{i + 1}. Bölümün açıklaması:");
                bolum.Aciklama = Console.ReadLine();
                bolumler.Add(bolum);
                List<Ogrenci> ogrenciler = new List<Ogrenci>();
                for (int j = 0; j < 3; j++)
                {
                    Ogrenci ogrenci = new Ogrenci();
                    Console.Write($"{i + 1}. Öğrenci Id giriniz:");
                    ogrenci.Id = int.Parse(Console.ReadLine());
                    Console.Write($"{i + 1}. Öğrenci adı:");
                    ogrenci.Ad = Console.ReadLine();
                    Console.Write($"{i + 1}. Öğrenci soyadı:");
                    ogrenci.Soyad = Console.ReadLine();
                    Console.Write($"{i + 1}. Öğrenci no:");
                    ogrenci.OgrNo = int.Parse(Console.ReadLine());
                    Console.Write($"{i + 1}. Öğrenci yaşı:");
                    ogrenci.Yas = int.Parse(Console.ReadLine());
                    ogrenciler.Add(ogrenci);
                    
                }
                bolum.Ogrenciler = ogrenciler;

            }

            foreach (var bolum in bolumler)
            {
                Console.WriteLine($"Bölüm Id: {bolum.Id} - Bölüm Adı: {bolum.Ad} - Bölüm açıklaması: {bolum.Aciklama}");
                foreach (var ogrenci in bolum.Ogrenciler)
                {
                    Console.WriteLine($"Öğrenci Id: {ogrenci.Id} - Öğrenci Adı: {ogrenci.Ad} - Öğrenci SoyAdı: {ogrenci.Soyad} - Öğrenci yaş: {ogrenci.Yas} - Öğrenci no: {ogrenci.OgrNo}");
                }
            }



        }
    }
}
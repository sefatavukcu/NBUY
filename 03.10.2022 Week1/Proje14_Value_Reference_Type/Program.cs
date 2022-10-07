namespace Proje14_Value_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            (Value type -- (int, double, bool etc.)) (Reference type -- (DateTime, Random etc.))

            HEAP: Developerin ram de direkt erişime geçebileceği yer
            STACK: 

            new = stack kısmında yeni bir obje oluşturur.
            her new yeni bir nesne oluşturur.

            Heap ta yok ise heap kısmında yazan adrese gider yani stack kısmına. 

            Heap değer tutar.

            */

            
            //int a = 45;
            //int b = a + 2;

            
           // Random rnd = new Random();


            Kisi kisi1= new Kisi();
            kisi1.Ad = "Sefa";
            kisi1.Yas = 22;
            kisi1.Meslek = "Geomatics Engineer";

            Kisi kisi2= new Kisi();
            kisi2.Ad = "Elif";
            kisi2.Yas = 21;
            kisi2.Meslek = "Volleyball Player";

            Kisi kisi3 = new Kisi();
            kisi3.Ad = "Cem";
            kisi3.Yas = 34;
            kisi3.Meslek = "Pilot";


            Araba araba1 = new Araba();
            araba1.Marka = "Opel";
            araba1.Renk = "Siyah";

            DateTime bugun = DateTime.Now;
            Random rnd2 = new Random();


        }
        // Class tan nesne üretecğimiz şeylere property diyebiliriz.
         // ? değişkenin boş olabileceğini bilindiğinden uyarıyı kapatır.
         // public olanlar binevi şablon.
         // public olanlar dışarıdan erişilebilir.
         // private olanlar sadece class ın içinden erişilebilir.
         // Static kendisinden nesne oluşturulmayan classtır.
        class Kisi
        {
            public string? Ad { get; set; }

            public int Yas { get; set; }

            public string? Meslek { get; set; }

        }


        class Araba
        {
            public string Marka { get; set; }

            public string Renk { get; set; }

            private string VitesTuru { get; set; }   // Erişim belirleyici: Bir property'nin dışarıda yani içinde bulunduğu classın dışında erişim seviyesinin belirleyen anahtar sözcüklere denir. Eğer herhangi bir erişim belirleyici kullanılmamışsa, private olarak kabul edilir.
            // Erişim Belirleyiciler:
            // 1) public
            // 2) private
            // 3) internal
            // 4) protected


            
        }
    }
}
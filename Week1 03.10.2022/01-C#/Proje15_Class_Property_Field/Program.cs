namespace Proje15_Class_Property_Field
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrNo = 182912056;
            ogrenci1.Ad = "Sefa Tavukcu";
            ogrenci1.Sinif = "12C";

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.OgrNo = 192912036;
            ogrenci2.Ad = "Ali Yılmaz";
            ogrenci2.Sinif = "11A";

            Ogrenci ogrenci3 = new Ogrenci() 
            { 
                OgrNo = 202912017, 
                Ad = "Kerem Ak", 
                Sinif = "10B" 
            };

            Ogrenci[] ogrenciler = {ogrenci1,ogrenci2, ogrenci3};

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine($"Ad: {ogrenciler[i].Ad}, Sınıf: {ogrenciler[i].Sinif} ");
            //}


            foreach (var ogrenci in ogrenciler)                             // Diziler aslında bir collection.
            {
                Console.WriteLine(ogrenci.Ad + " " + ogrenci.Sinif);
            }

            //int[] sayilar = { 32, 65, 99, 12 };
            //foreach (var siradakiSayi in sayilar)
            //{
            //    Console.WriteLine(siradakiSayi*siradakiSayi);
            //}


        }

        class Ogrenci
        {
            private int ogrNo;  // field
            // property alt kısım
            public int OgrNo
            {
                get { return ogrNo; }
                set { ogrNo = value; }
            }


            private String ad;

            public String Ad
            {
                get { return ad.ToUpper(); }         // Ekrana ne göstermezsek istersek burada değiştirebiliriz... ÖNEMLİ!!!  
                set { ad = value; }
            }


            public string Sinif { get; set; }



        }
    }
}
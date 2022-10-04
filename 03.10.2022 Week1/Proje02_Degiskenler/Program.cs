namespace Proje02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir degiskene ism verirken:
            // 1) Alfanumerik karakterler kullanilmaz. ( "_"  haric)
            // 2) Turkce karakter kullanilmaz. (zorunlu degil)
            // 3) Ozel ya da ayrilmis sozcukler kullanilmaz. (string static)
            // 4) Degisken isimleri kucuk buyuk harf duyarlidir.
            // 5) ctrl+k+c yorum satiri
            // 6) ctrl+k+u yorum satiri kaldir
            // 7) /*   */  coklu comment satiri yapma
            // string adSoyad;  // tercih edilen degisken atama yontemi (ilk kucuk, ikinci kelime buyuk)

            /*
            string adSoyad = "Ali Turap";

            Console.WriteLine(adSoyad);
            */

            /*
            int yas = 17;
            Console.WriteLine(yas);

            string adSoyad = "Murat Yılmaz";
            Console.WriteLine(adSoyad);

            Console.WriteLine("Adı: " + adSoyad + "\nYaş: " + yas);
            */

            // Tam Sayı
            //Console.WriteLine(byte.MinValue + "---" + byte.MaxValue); // byte min max sayi degerleri araligi
            //Console.WriteLine(int.MinValue + "---" + int.MaxValue);  // int min max sayi degerleri araligi

            //int sayi1 = 3899;    // int veri tipi 32 bitlik
            //byte sayi2 = 255;  // byte veri tipi 8 bitlik 255e kadar sayilari yazabilir.
            //long sayi3 = 234565123656; // long veri tipi 64 bitlik

            //string sayi4 = "15";
            //Console.WriteLine(sayi4+2);

            // Ondalık Sayı

            //float a = 10.5f;  // ondalık sayi yazinca sonuna f getirmelisin.
            //double b = 20.9;
            //decimal c = 101.89m; // sonuna m yazılmalı. (parasal degerler)

            // Karakter ve Metin

            string name = "Burak Ahsen";
            char cinsiyet = 'E'; // tek tirnak ve tek karakter tutabilen tip.


            // Mantıksal

            bool evliMi = false; // icinde sadece true veya false degeri atanabilir.
            


        }
    }
}
namespace Proje02_Methods
{
    public class Program
    {

        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine($"Toplam: {toplam}");
        }

        static void Cikar(int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine($"Fark: {cikar}");
        }

        static int Toplaa(int sayi1, int sayi2)      // tip kullanılırsa return kullanılmalı !!!
        {                                           // void varsa return kullanılmaz !!!
            return sayi1 + sayi2;
        }

        static int Cikarr(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            return fark;
        }

        static void Main(string[] args)   // METHOD
        {
            //    Console.Write("Birinci Sayıyı Giriniz: ");
            //    int s1 = int.Parse(Console.ReadLine());
            //    Console.Write("İkinci Sayıyı Giriniz: ");
            //    int s2 = int.Parse(Console.ReadLine());

            //    int cikar = Cikar(s1,s2);
            //    int toplam = Topla(s1,s2);

            //    Console.WriteLine($"Fark: {cikar}");
            //    Console.WriteLine($"Toplam: {toplam}");
            //    Console.WriteLine(toplam-cikar);

            // Köşeli parantez opsiyonel
            // Bir işlemin farklı kullanım şekillerini oluşturmaya overload denir...


            //Console.WriteLine(SiraNo("Wissen Akademie", 'a'));
            //Console.WriteLine(varMi("Wissen Akademie", 'a'));


            MethodOverload methodOverload = new MethodOverload();
            methodOverload.DenemeMethodu();

        }

        // 1-) Kendisine verilen metnin içinde, aradığınız karakterin kaçıncı sırada olduğunu bulan metodu hazırlayın.
        // 2-) Kendisine verilen metnin içinde, aradığınız karakterin olup olmadığını bize söyleyen bir metodu hazırlayın.
        // public dışarıya erişime açık demek.... Methodlarda public yaparak kullanabiliriz.

        static int SiraNo (string metin, char karakter)
        {
            int sonuc = metin.IndexOf(karakter);
            return sonuc;
        }

        static bool varMi (string metin, char karakter)
        {
            bool sonuc = metin.Contains(karakter);
            return sonuc;
        }

    }
}
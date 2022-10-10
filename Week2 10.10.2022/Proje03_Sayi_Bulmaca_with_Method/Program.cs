namespace Proje03_Sayi_Bulmaca_with_Method
{
    public static class Program
    {

        public static int Tahmin ()
        {
            Console.Write("Tahminizi giriniz: ");
            int tahminDeger = int.Parse(Console.ReadLine());
            return tahminDeger;
        }

        public static int Random ()
        {
            int uretilenSayi = 0;
            Random rnd = new Random();
            uretilenSayi = rnd.Next(1, 101);
            return uretilenSayi;
        }
        public static int[] Hak ()
        {
            int hak = 1;  // Kullanıcının o sırada kaçıncı hakkını kullandığı bilgisi...
            int hakSiniri = 5;  // Kullanıcının toplam kaç hakka sahip olduğunun bilgisi...
            int[] dizi = { hak, hakSiniri };
            hak++;
            return dizi;
        }



        static void Main(string[] args)
        {
            // Sayı bulmaca oyununu, yeni öğrenilen methods konusu bağlamında yeniden hazırlayınız.
            // 5 tercih hakkı olsun.
            // Puan Sistemi olsun. (1. tercih:50 puan, her tercih hakkı düştükçe 10'ar puan düşsün.)
            // Oyunu kaybettiğinde ya da kazandığında yeniden oynamak istiyor ise oynayabilirsin.

            int random = Random();
            Console.WriteLine(random);
            int deger = Tahmin();
            Console.WriteLine(deger);
            string mesaj = "";
            do
            {
                
               
                if (deger > random)
                {
                    mesaj = "Büyük Girdin...";
                }
                else if (deger < random)
                {
                    mesaj = "Küçük girdin..";
                }
                if (deger != random)
                {
                    Hak(++);
                    if (Hak() <= hakSiniri)
                    {
                        Console.WriteLine(mesaj);
                    }
                }
            }
            while (hak <= hakSiniri && deger != random);

        }
    }
}
namespace Proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i+1}-) Hello, World!");
            //}

            /*
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam = toplam + i;
                //toplam += i;
                
            }
            Console.WriteLine(toplam);
            */
            /*
            // 1 ile 10 arasındaki çift sayıların toplamını buldurun.

            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i%2==0)
                {
                    toplam += i;
                }
                
            }
            Console.WriteLine(toplam);
            */

            /*
            // 1-10 arası tek ve çift sayıların toplamı
            int tek = 0;
            int cift = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    cift += i;
                }
                else
                {
                    tek += i;
                }

            }
            Console.WriteLine($"Tek: {tek}");
            Console.WriteLine($"Çift: {cift}");
            */

            /*
            // Klavyeden 2 sayı girilsin. Bu sayıların arasındaki sayıların toplamını bulduralım.


            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = sayi1; i <= sayi2; i++)
            {
                toplam += i;

            }

            Console.WriteLine($"Toplam: {toplam}");
            */

            /*
            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            if (sayi2>sayi1)
            {
                for (int i = sayi1; i <= sayi2; i++)
                {
                    toplam += i;

                }
            }
            else
            {
                for (int i = sayi1; i >= sayi2; i--)
                {
                    toplam += i;

                }
            }

            Console.WriteLine($"Toplam: {toplam}");
            */

            /*
            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int min = Math.Min(sayi1, sayi2);   
            int max = Math.Max(sayi1, sayi2);   

            for (int i = min; i <= max; i++)
            {
                toplam += i;

            }

            Console.WriteLine($"Toplam: {toplam}");
            */

            /*
            // Soru: Program kullanıcıdan bir sayı girmesini istesin. Ancak kullanıcı sayı girmeye devam ettikçe girilen sayıların toplanmasını sağlayın. Sayı Adedi belirsizdir. Uygulamanın bitip ekrana toplamı yazdırabilmesi için sayı yerine exit yazmasını kontrol edeceğiz.


            int toplam = 0;
            string girilenDeger = "";

            for (int i = 1; i < 10000000; i++)
            {
                Console.Write($"{i}. sayıyı giriniz (Çıkış için exit): ");
                girilenDeger = Console.ReadLine();

                if (girilenDeger.ToLower() == "exit")  // if küçük büyük harf duyarlıdır.
                {
                    break;  // İçinde bulunulan döngünün tamamlanmasını beklemeden istenilen bir anda durdurulması için kullanılır.
                }
                toplam += Convert.ToInt32(girilenDeger);

            }
            Console.WriteLine(toplam);

            */

            /*
            int toplam = 0;
            string girilenDeger = "";
            string sonucMetin = "";
            string sonEk = " + ";

            for (int i = 1; i < 10000000; i++)
            {
                Console.Write($"{i}. sayıyı giriniz (Çıkış için exit) [Geçerli Toplam: {toplam}]: ");
                girilenDeger = Console.ReadLine();
                

                if (girilenDeger.ToLower() == "exit")  // if küçük büyük harf duyarlıdır.
                {
                    break;  // İçinde bulunulan döngünün tamamlanmasını beklemeden istenilen bir anda durdurulması için kullanılır.
                }
                sonucMetin += girilenDeger + " + ";
                toplam += Convert.ToInt32(girilenDeger);

            }
            int alinacakKisimUzunlugu = sonucMetin.Length - sonEk.Length; 
            sonucMetin = sonucMetin.Substring(0,alinacakKisimUzunlugu);  // Bir metnin içinden istenilen kadar kısmı istenilen yerden siliniyor.
            Console.WriteLine($"{sonucMetin} : {toplam}");
            */

            /*
            // 5x5 lik bir kare biçimini yıldız işaretleriyle oluşturan uygulamayı yazınız.
            /*
             *       *****
             *       *****
             *       *****
             *       *****
             *       *****
            */
            /*
            string isaret = "*";
            int satir = 5;
            int sutun = 5;

            for (int i = 0; i < satir; i++)
            {

                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(isaret);

                }
                Console.WriteLine();

            }
            */

            // 5x5 lik bir içi boş kare biçimini yıldız işaretleriyle oluşturan uygulamayı yazınız.
            /*
             *       *****
             *       *   *
             *       *   *
             *       *   *
             *       *****
            */
            /*
            //string isaret = "*";
            int satir = 5;
            int sutun = 5;

            for (int i = 1; i <= satir; i++)
            {



                for (int j = 1; j <= sutun; j++)
                {
                    if ((i == satir || i == 1))  // Eğer 1. veya son satırdaysan
                    {
                        Console.Write("*");
                    }
                    else if (j==1 || j==sutun) // Eğer 1.veya son sütundaysan
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            */

            // Ödev: Üstteki içi boş olan kareyi oluşturan uygulamayı adım adım çalıştırarak anlamaya çalış!!

            // ÖDEV1: 1-100 arasındaki sayıların ortalamasını bulduran program...
            // ÖDEV2: 1-100 arasındaki çift, tek ve 5'in katı olan sayıların adetleri ve toplamlarını ekrana yazdıran program.
            // ÖDEV3: Aşağıdaki yüksekliği 5, tabanı 9 br olan yıldızlardan oluşan dik üçgeni çizdiren program...
            /*
             * *
             * ***
             * *****
             * *******
             * *********
             * 
             * */

            int[] sayilar = { 32, 65, 99, 12 };
            foreach (var siradakiSayi in sayilar)
            {
                Console.WriteLine(siradakiSayi * siradakiSayi);
            }



        }
    }
}
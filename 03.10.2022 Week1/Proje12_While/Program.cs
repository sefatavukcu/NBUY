namespace Proje12_While;
class Program
{
    static void Main(string[] args)
    {
        // For tekrarı belli olduğu durumlarda kullanılır.
        // While tekrarı belli olmayan durumlarda kullanılır. Belirli koşul devam ettikçe kullanılır...
        /*
        int sayac = 1;

        while (sayac<=5)
        {
            Console.WriteLine("Hello, World!");
            sayac++;
        }
        */
        /*
        int toplam = 0;
        string girilenDeger ="";
        int sayac = 1;

        while (girilenDeger!="exit")
        {
            Console.WriteLine($"{sayac}. sayıyı giriniz. (Çıkış için exit yazınız):");
            girilenDeger = Console.ReadLine();
            // if (girilenDeger!="exit")
            // {
            //     toplam += Convert.ToInt32(girilenDeger);
            // }
            try
            {
                toplam += Convert.ToInt32(girilenDeger);
            }
            catch (System.Exception)
            {
                Console.WriteLine(toplam);
                break;
            }

            sayac++;
        }
        */

        // SORU: Klavyeden exit yazılana kadar isim girilmesini isteyen program...
        // ÇÖZÜM1
        // string isim = "";

        // while (isim!="exit")
        // {
        //     Console.Write("İsim giriniz: ");
        //     isim = Console.ReadLine();
        // }
        // Console.WriteLine("Program sona erdi!");

        // ÇÖZÜM2
        /*
        string isim;

        do
        {
            Console.Write("İsim giriniz: ");
            isim = Console.ReadLine();
        } while (isim!="exit");
        Console.WriteLine("Program sona erdi!");
        */

        // Klavyeden exit yazılana kadar sayı almaya devam eden ve bu sayıların toplamını exit yazılınca ekrana yazan program...
        // Do-While
        /*
        string girilenDeger;
        int sayac=1;
        int toplam = 0;

        do
        {
            Console.WriteLine($"{sayac}. sayıyı giriniz: ");
            girilenDeger = Console.ReadLine();
            if(girilenDeger!="exit") toplam += Convert.ToInt32(girilenDeger);
            sayac++;
        } while (girilenDeger!="exit");
        Console.WriteLine(toplam);
        */

        // Rastgele sayı üretme
        /*
        Random rastgele = new Random();
        int rastgeleSayi = rastgele.Next();
        Console.WriteLine(rastgeleSayi);
        int rastgeleSayi2 = rastgele.Next(999999); // 999999 dahil değildir. (0 dahil.)
        Console.WriteLine(rastgeleSayi2);
        int rastgeleSayi3 = rastgele.Next(500,2000);  // 500 - 2000 arası sayı üretir. (500 dahil -- 2000 hariç)
        Console.WriteLine(rastgeleSayi3);
        */

        
        // OYUN: Uygulamanın rastgele üreteceği bir sayıyı kullanıcının tahmin etmesini isteyeceğiz...
        // Rastgele üretilecek sayı 1-11 arası olsun...
        // Kullanıcı rastgele sayıdan küçük ya da büyük bir sayı girdiğinde kullanıcıya uygun bir şekilde mesaj versin...
        // Kullanıcı doğru sayıyı tahmin ettiyse ya da 3 or 5 hakkını kullandıysa program sona ersin...

        
        int tahmin;
        Random rnd = new Random();
        int uretilenSayi = rnd.Next(1,101);
        Console.WriteLine("********");
        Console.WriteLine(uretilenSayi);
        int hak = 1;  // Kullanıcının o sırada kaçıncı hakkını kullandığı bilgisi...
        int hakSiniri = 5;  // Kullanıcının toplam kaç hakka sahip olduğunun bilgisi...
/*
        do
        {
            Console.Write($"{hak}. Tahmininizi giriniz: ");
            tahmin = Convert.ToInt32(Console.ReadLine());
            

            if (hak==hakSiniri && uretilenSayi!=tahmin)
            {
                Console.WriteLine("Kaybettiniz...");
                break;
            }


            if (hak<=hakSiniri)
            {
                if (tahmin>uretilenSayi)
                {
                Console.WriteLine("Büyük sayı girdiniz...");
                }
                else if (tahmin<uretilenSayi)
                {
                Console.WriteLine("Küçük sayı girdiniz...");
                }
                else
                {
                Console.WriteLine("Tebrikler...");
                }
            }
            hak++;
        

        } while (tahmin!=uretilenSayi && hak<=hakSiniri);

        */

        do
        {
            Console.Write($"{hak}. Tahmininizi giriniz: ");
            tahmin = Convert.ToInt32(Console.ReadLine());
            if (tahmin>uretilenSayi)
            {
                Console.WriteLine("Büyük girdin..");
            }
            else if (tahmin<uretilenSayi)
            {
                Console.WriteLine("Küçük girdin..");
            }
            if (tahmin!=uretilenSayi)
            {
                hak++;
                if (hak<=hakSiniri)
                {
                    Console.WriteLine("Kaybettin...");
                }
            }
            else
            {
                Console.WriteLine("Kazandın...");
            }
        } while (hak<=hakSiniri && tahmin != uretilenSayi);
        //eğer program bu satıra gelmiş ise ya doğru tahminde bulunulmuştur ya da hak sona ermiştir.

    }
}

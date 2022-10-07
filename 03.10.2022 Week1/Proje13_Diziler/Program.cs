namespace Proje13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string ad;
            ad = "Engin";

            string adSoyad1 = "Ali Yılmaz, Burak Keskin, Cemal Gündem";

            string[] adlar = new string[7];   // İçinde 3 adet string bilgi tutabilecek bir dizi.
            adlar[0] = "Ali Yılmaz";          // 
            adlar[1] = "Burak Keskin";        // Sürekli yeni bir string vs eklenme ihtimalinden dolayı genelde çok kullanılmayı tercih edilmez.
            adlar[2] = "Cemal Gündem";
            adlar[3] = "Kemal Kurt";
            adlar[4] = "Selma Kurt";
            adlar[5] = "Begüm Kaplan";
            adlar[6] = "Emre Mor";
            //Console.WriteLine(adlar[1]);

            for (int i = 0; i < adlar.Length; i++)
            {
                Console.WriteLine(adlar[i]);
            }
             */

            //int toplam = 0;

            //int[] yaslar = new int[3];
            //int[] rakamlar = { 56, 89, 32, 90, 5, 84, 13 };

            //    for (int i = 0; i < rakamlar.Length; i++)
            //    {
            //        toplam+=rakamlar[i];
            //    }

            //    Console.WriteLine(toplam);
            //}

            //string okul = "Wissen Akademie";
            //Console.WriteLine(okul[0]);

            /*

            // Çalışma: Klavyeden kullanıcının adını soyadını girmesini isteyiniz.
            // Girilen ad soyadı aşağıya doğru Büyük Harflerle yazdırınız.

            
            Console.Write("İsminizi Giriniz:");
            string isim = Console.ReadLine().ToUpper();

            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(isim[i]);
            }
            */

            /*
            Console.Write("Bir metin giriniz:");
            string girilenMetin = Console.ReadLine().ToLower();
            Console.Write("Hangi karakterin sırasını bulmamı istersiniz:");
            string karakter = Console.ReadLine().ToLower();

            int siraNo = girilenMetin.IndexOf(karakter)+1;
            Console.WriteLine($"Girilen Metin: {girilenMetin}\nAradığınız Karakter: {karakter}\n Sıra No: {siraNo}");
            */

            /*
            int[] rakamlar = { 56, 89, 99, 99, 84, 27 };

            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. eleman:\t{rakamlar[i]}");
            //}


            //Console.WriteLine();
            // Kendimiz en büyük sayıyı buluyoruz.

            //Console.WriteLine($"En Küçük:\t{rakamlar.Min()}");    // \t  bir tab kadar boşluk bırakır...
            //Console.WriteLine($"En Büyük:\t{rakamlar.Max()}");

            int enBuyuk = 0;
            int enKucuk = 0;

            for (int i = 0; i < rakamlar.Length; i++)
            {
                if (enBuyuk < rakamlar[i])
                {
                    enBuyuk = rakamlar[i];
                }
                if (enBuyuk > rakamlar[i])
                {
                    enKucuk = rakamlar[i];
                }
            }
            Console.WriteLine(enBuyuk);
            Console.WriteLine(enKucuk);

            */

            //***************************
            // İsteğe bağlı çalışma ödevi: Bu diziyi küçükten büyüğe sıralama...
            //***********************

            //Console.WriteLine("Dizinin orijinal hali.");
            //Console.WriteLine("**********************");

            //int[] rakamlar = { 56, 89, 99, 99, 84, 27 };

            //Console.WriteLine("Dizinin ters çevrilmiş hali");
            //Console.WriteLine("***************************");
            //Array.Reverse(rakamlar);                                     // Dizinin sırasını ters çevirir.

            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. eleman:\t{rakamlar[i]}");
            //}



            //int[] rakamlar = { 56, 89, 99, 99, 84, 27 };

            //Console.WriteLine("Dizinin küçükten büyüğe çevrilmiş hali");
            //Console.WriteLine("***************************");
            //Array.Sort(rakamlar);                                     // Sort(default olarak) Diziyi küçükten büyüğe sıralar...

            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. eleman:\t{rakamlar[i]}");
            //}


            //int[] rakamlar = { 56, 89, 99, 99, 84, 27 };

            //Console.WriteLine("Dizinin büyükten küçüğe sıralanmış hali");
            //Console.WriteLine("***************************");
            //Array.Sort(rakamlar);
            //Array.Reverse(rakamlar);     // Burada önce küçükten büyüğe sıralayıp daha sonra sıralamasının tersini alarak büyükten küçüğe sıralanmış   oldu.

            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. eleman:\t{rakamlar[i]}");
            //}




            //  ÖRNEKLER

            // ÖRNEK1  :   sayılar dizisinin ortalamasını bulup ekrana yazdırıp.

            //int[] sayilar = { -5, 6, 8, 12, 56, -78, 90, 113 };
            //int toplam = sayilar.Sum();   // toplamı bulur.
            // Console.WriteLine(toplam);


            // Örnek2:   Sayılar dizisindeki çift sayıları yazdıralım

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2==0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            // Örnek 3: Sayılar dizisindeki sayıları yanlarında pozitif, negatif ya da işaretsiz olma bilgileri ile yazdıralım. 

            //string tip = "";
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    tip = sayilar[i]>0 ? "Pozitif" : sayilar[i]<0 ? "Negatif" : "İşaretsiz";
            //    Console.WriteLine($"{i+1}. Sayı : {sayilar[i]} - Tipi: {tip}");
            //}

            // Örnek 4: Kullanıcının gireceği bir metnin içindeki sesli harf sayısını ekrana yazdıralım.

            //char[] sesliHarf = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            //int sesliHarfAdedi = 0;
            //Console.Write("Bir metin giriniz: ");
            //string girilenMetin = Console.ReadLine().ToLower();

            //for (int i = 0; i < girilenMetin.Length; i++)
            //{
            //    if (sesliHarf.Contains(girilenMetin[i]))  // Contains içinde geçiyor mu???
            //    {
            //        sesliHarfAdedi++;
            //    }
            //}
            //Console.WriteLine(sesliHarfAdedi);

            // Örnek 5:Klavyeden girilen bir cümledeki yine kavyeden girilecek bir kelimenin kaç kez geçtiğini bulduralım..

            //string ornekMetin = "Sefa Murat Tavukçu";
            //string[] kelime = ornekMetin.Split(" ");   //  Split ayırmak için kullanılır.

            //for (int i = 0; i < kelime.Length; i++)
            //{
            //    Console.WriteLine(kelime[i]);
            //}

            //int sozcukAdedi = 0;

            //Console.Write("Bir metin giriniz: ");
            //string girilenMetin = Console.ReadLine();
            //Console.Write("Adedini bulunması istenen sözcüğü giriniz: ");
            //string saySozcuk = Console.ReadLine();
            //string[] girDizi = girilenMetin.Split(" ");

            //for (int i = 0; i < girDizi.Length; i++)
            //{
            //    if (saySozcuk.ToLower() == girDizi[i].ToString().ToLower()) 
            //    {
            //        sozcukAdedi++;
            //    }
            //}
            //Console.WriteLine($"'{girilenMetin}' içinde '{saySozcuk}' sözcüğü {sozcukAdedi} kez geçmektedir.");

            //******************************************************************************
            // Araştırma Ödevi: Çok boyutlu dizileri araştır.
            //******************************************************************************

            //******************************************************************************
            // PROJE ÖDEVİ: İçinde türkçe karakterler hariç tüm harfler, 0-9 arası rakamlar,
            // nokta(.), virgül (,), artı(+), eksi(-), karakterleri bulunabilecek toplam uzunluğu
            // 6 karakter olacak şekilde RASTGELE ŞİFRE üreten programı yazınız...
            //******************************************************************************

            // engin.ergul@wissenakademie.com // 

        }
    }
}
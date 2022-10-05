namespace Proje05_Metinsel_Metodlar;
class Program
{
    static void Main(string[] args)
    {
        // Bu projede metinsel işlemlere dair bazı metotlar öğreneceğiz.

        /*
        string metin = "Wissen Akademie";
        int uzunluk = metin.Length;   // Değişkendeki karakter harf sayısını bulur.
        Console.WriteLine($"{metin} metni {uzunluk} karakterdir.");
        Console.WriteLine($"Uzunluk: {uzunluk}");
        */
        /*
        string metin = "WİSSEN";
        string kucukMetin = metin.ToLower();  // Küçük harfe getirme
        Console.WriteLine(kucukMetin);
        string buyukMetin = kucukMetin.ToUpper();  // Büyük harfe getirme
        Console.WriteLine(buyukMetin);
        */
        /*
        string m1 = "Wissen";
        string m2 = "Wissen";
        int sonuc = String.Compare(m1, m2);  // m1 m2 karşılaştır. 
        Console.WriteLine(sonuc);
        */
        /*
        Console.WriteLine("Birinci sayıyı, metni giriniz.");
        string m1 = Console.ReadLine();
        Console.WriteLine("İkici sayıyı, metni giriniz.");
        string m2 = Console.ReadLine();
        int sonuc = String.Compare(m1, m2);
        if (sonuc==0)
        {
            Console.WriteLine("Girilen iki metin birbirine eşittir.");
        }
        else
        {
            Console.WriteLine("Girilen iki metin birbirinden farklıdır.");
        }
        */
        /*
        string m1 = "İşkur ";
        string m2 = "Eğitimleri ";
        string m3 = "Wissen";
        //string sonuc = m1 + m2;
        string sonuc = String.Concat(m1+ m2+ m3);
        Console.WriteLine(sonuc);
        */
        /*
        string ad = "Sefa";
        int yas = 22;
        string okul = "BAU";
        Console.WriteLine($"Benim adım {ad}. {yas} yaşındayım. Okuduğum okul {okul}");
        Console.WriteLine("Benim adım "+ad+". "+yas+" yaşındayım. "+ "Okuduğum okul "+okul);
        string sonuc = String.Concat("Benim adım " + ad + ". " + yas + " yaşındayım. "+ "Okuduğum okul "+okul);
        Console.WriteLine(sonuc);
        */
        /*
        string metin = "Merhaba. Bu hafta eğitime başladık.";
        bool sonuc = metin.Contains("m"); // hem string hem de karakteri de tanır.
        Console.WriteLine(sonuc);
        */
        /*
        string adres = "Selami Şehit Ali mah. Can sok. No:6 Kadıköy/Ankara";
        //bool sonuc = adres.EndsWith("İstanbul");  // Biten sözcük
        //bool sonuc2 = adres.StartsWith("İstanbul"); // Başlayan sözcük
        //Console.WriteLine(sonuc + " "+ sonuc2);

        // adres içerisindeki c harfi kaçıncı sırada
        //int siraNo = adres.IndexOf('C');  // kaçıncı sırada olduğunu gösterir. Eğer -1 döndürürse içinde yoktur.
        //Console.WriteLine($"C harfi {adres} içinde {siraNo} sıradadır.");

        //string aranan = "ş";
        //int siraNo = adres.ToLower().IndexOf(aranan.ToLower());
        //Console.WriteLine($"C harfi {adres} içinde {siraNo} sıradadır.");

        string aranan = "şehit ali";
        int siraNo = adres.ToLower().IndexOf(aranan.ToLower());
        Console.WriteLine($"{aranan} ifade {adres} içinde {siraNo} sıradan başlamaktadır.");
        */
        /*
        string metin = "Wissen Akademie";
        Console.WriteLine($"Metnin ilk hali: {metin}"); // remove: sildirme
        Console.WriteLine($"Akademie ifadesi silindikten sonraki hali: {metin.Remove(7)}");
        Console.WriteLine($"Aka ifadesi silindikten sonraki hali: {metin.Remove(7,3)}");
        */
        /*
        string urunAd = "IPhone 13 Pro";
        // iphone-13-pro dönüştürme
        //string sonuc = (urunAd.Replace(' ', '-')).ToLower();  // string null olabilir ama char varsa içinde bir şey olmalı. (char: boş bırakılmaz.)
        string sonuc = urunAd.ToLower().Replace(" ", "-");
        Console.WriteLine(sonuc);
        string sonuc2 = urunAd.Replace("IPhone","Samsung");
        Console.WriteLine(sonuc2);
        */

    }
}

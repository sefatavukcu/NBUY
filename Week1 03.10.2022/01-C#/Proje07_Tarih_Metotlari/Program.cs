namespace Proje07_Tarih_Metotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);

            DateTime dogumTarihi = new DateTime(2000, 01, 13);  
            Console.WriteLine(dogumTarihi);
            DateTime bugun = DateTime.Now;                // Bugünün tarihi
            TimeSpan span = bugun.Subtract(dogumTarihi);  
            Console.WriteLine(Math.Floor(span.TotalDays));    // Doğumdan bugüne kaç gün yaşadım.
            */

            /*
            DateTime bugun = DateTime.Now;
            Console.WriteLine(bugun.ToLongDateString());  // 5 Ekim 2022 Çarşamba
            Console.WriteLine(bugun.ToLongTimeString());  // 13.35.23
            Console.WriteLine(bugun.DayOfWeek);           // wednesday
            Console.WriteLine(bugun.ToShortDateString()); // 5.10.2022
            Console.WriteLine(bugun.ToShortTimeString()); // 13.35
            */

            /*
            // Bir sonraki yılın ilk gününün tarihini bulalım.
            DateTime bugun = DateTime.Now;
            int yil = bugun.Year + 1;
            DateTime sonuc = new DateTime(yil, 1, 1);
            Console.WriteLine(sonuc.ToLongDateString());
            */

            /*
            // Bir sonraki ayın ilk gününü bulalım. 
            DateTime bugun = DateTime.Now;
            int ay = bugun.Month + 1;
            DateTime sonuc = new DateTime(bugun.Year, ay, 1);
            Console.WriteLine(sonuc.ToLongDateString());
            */

            /*
            DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun+1);
           
            
            ÖDEV
            
            Ertesi günün tarihini bulup ekrana yazdıran programı yazınız.
            */
            



             
        }
    }
}
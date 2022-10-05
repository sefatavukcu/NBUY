namespace Proje10_Switch_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // klavyeden girilen bir sayının 5 olması halinde ise (2 katı), 10 olması halinde (3 katı) ya da 15 olması halinde (4 katı) ekrana yazan programı hazırlayalım.
            // Eğer üçü de değilse "Tanınmayan değer yazsın."
            /*
            Console.Write("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sonuc = 0;

            switch (sayi1)
            {
                case 5:
                    sonuc = sayi1 * 2;
                    break;
                case 10:
                    sonuc = sayi1 * 3;
                    break;
                case 15:
                    sonuc = sayi1 * 4;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            if (sonuc == 0)
            {
                Console.WriteLine("Tanımlanmayan değer...");
            }
            else
            {
                Console.WriteLine($"Sonuç: {sonuc}");
            }

            //if (sayi1 == 5)
            //{
            //    Console.WriteLine(sayi1*2);
            //}
            //else if (sayi1 == 10)
            //{
            //    Console.WriteLine(sayi1*3);
            //}
            //else if (sayi1 == 15)
            //{
            //    Console.WriteLine(sayi1*4);
            //}
            //else
            //{
            //    Console.WriteLine("Tanınmayan değer...");
            //}
            */

            /*
            // x 10 dan küçükse 2 ile çarp
            // x 11 ile 20 arasındaysa 3 ile çarp
            // x 21 ile 50 arasındaysa 4 ile çarp
            // x 51 ile 100 arasındaysa 5 ile çarp
            // x 100 den büyükse 10 ile çarp

            // Çözüm1: if ile çözün.

            int x = 150;
            int sonuc = 0;
            int katSayi = 0;

            if (x<=10)
            {
                katSayi = 2;
            }
            else if (x <= 20)
            {
                katSayi = 3;
            }
            else if (x <= 50)
            {
                katSayi = 4;
            }
            else if (x <= 100)
            {
                katSayi = 5;
            }
            else
            {
                katSayi = 10;
            }
            Console.WriteLine($"X: {x}, Sonuç: {x} x {katSayi}: {x*katSayi}");
            */

            /*
            int x = 150;
            int katSayi = 0;

            switch (x)
            {
                case <= 10:
                    katSayi = 2;
                    break;
                case <= 20:
                    katSayi = 3;
                    break;
                case ( >=21 and <= 50):
                    katSayi = 4;
                    break;
                case (>=51 and <= 100):
                    katSayi  =5;
                    break;
                default:
                    katSayi = 10;
                    break;
            }

            Console.WriteLine($"X: {x}, Sonuç: {x} x {katSayi}: {x * katSayi}");
            */


            // İçinde bulundğumuz günün hafta içi mi yoksa hafta sonu mu olduğunu bulalım.

            //DateTime tarih = new DateTime(2022, 10, 08);
            //DayOfWeek gun = tarih.DayOfWeek;

            //if (gun==DayOfWeek.Sunday || gun==DayOfWeek.Saturday)
            //{
            //    Console.WriteLine("Haftasonu...");
            //}
            //else
            //{
            //    Console.WriteLine("Haftaiçi...");
            //}


            //DateTime tarih = new DateTime(2022, 10, 08);
            //DayOfWeek gun = tarih.DayOfWeek;

            //switch (gun)
            //{
            //    case DayOfWeek.Monday:
            //    case DayOfWeek.Tuesday:
            //    case DayOfWeek.Wednesday:
            //    case DayOfWeek.Thursday:
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("Haftaiçi...");
            //        break;
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("Haftasonu...");
            //        break;
            //    default:
            //        break;
            //}

            //switch (gun)
            //{
            //    case DayOfWeek.Monday or DayOfWeek.Tuesday or DayOfWeek.Wednesday or DayOfWeek.Thursday or DayOfWeek.Friday:
            //        Console.WriteLine("Haftaiçi...");
            //        break;
            //    case DayOfWeek.Saturday or DayOfWeek.Sunday:
            //        Console.WriteLine("Haftasonu...");
            //        break;
            //    default:
            //        break;

            }
        }
    }
}
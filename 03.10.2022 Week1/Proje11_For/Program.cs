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

        }
    }
}
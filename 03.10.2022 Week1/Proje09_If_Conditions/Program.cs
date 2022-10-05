namespace Proje09_If_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             * if(logical ifade (bool))
             * {
             *      bool true ise yapılacak işler
             * }
             */

            /*
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi >= 0) 
            {
                Console.WriteLine("Merhaba Dünya");
            }
            */
            /*
            // Kullanıcıdan yaşını girmesini isteyelim. 
            // 18 yaşından küçüklere giriş yasak mesajı yazılsın.

            Console.Write("Lütfen yaşınızı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi<18)
            {
                Console.WriteLine("Giriş yasak!!!");
            }
            else if (sayi>18)
            {
                Console.WriteLine("İçeri Girebilirsiniz...");
            }

            else
            {
                Console.WriteLine("Veliniz ile birlikte geliniz...");
            }
            */

            /*
            // Girilen iki sayıdan büyük olanı yazdır.

            Console.Write("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1>sayi2)
            {
                Console.WriteLine($"Büyük Sayı: {sayi1}");
            }
            else if (sayi2>sayi1)
            {
                Console.WriteLine($"Büyük Sayı: {sayi2}");
            }
            else
            {
                Console.WriteLine("İki sayı birbirine eşittir.");
            }
            */

            /*
            // Girilen üç sayıdan büyük olanı yazdır

            Console.Write("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            // Doğru algoritma

            if (sayi1>=sayi2 && sayi1>=sayi3)
            {
                Console.WriteLine(sayi1);
            }
            else if (sayi2>=sayi1 && sayi2 >= sayi3)
            {
                Console.WriteLine(sayi2);
            }
            else if (sayi3>=sayi1 && sayi3>=sayi2)
            {
                Console.WriteLine(sayi3);
            }




            // Doğru olmayan algoritma

            //if (sayi1>sayi2)
            //{
            //    if (sayi1>sayi3)
            //    {
            //        Console.WriteLine(sayi1);
            //    }
            //}
            //if (sayi2>sayi1)
            //{
            //    if (sayi2>sayi3)
            //    {
            //        Console.WriteLine(sayi2);
            //    }
            //}
            //if (sayi3 > sayi1)
            //{
            //    if (sayi3 > sayi2)
            //    {
            //        Console.WriteLine(sayi3);
            //    }
            //}
            */
            /*
            Console.Write("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int buyukSayi = 0;

            if (sayi1>sayi2)
            {
                buyukSayi = sayi1;
            }
            else if (sayi2>sayi1)
            {
                buyukSayi = sayi2;
            }
            //else
            //{
            //    buyukSayi = sayi2;
            //}
            Console.WriteLine($"Büyük Sayı: {buyukSayi}");
            */

            //Console.Write("Birinci sayıyı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int buyukSayi = sayi1>sayi2 ? sayi1 : sayi2;
            //Console.WriteLine(buyukSayi);


            /*
            Console.Write("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string buyukSayi = sayi1 > sayi2 ? "Birinci sayı ikinci sayıdan büyüktür." : 
                sayi2 > sayi1 ? "İkinci sayı birinci sayıdan büyüktür." :
                     "İki sayı birbirine eşittir.";
            Console.WriteLine(buyukSayi);
            */



        }
    }
}
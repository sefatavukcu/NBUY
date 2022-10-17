using System.Collections;

namespace Proje12_OOP_Work01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IBolum> list = new List<IBolum>();
            string b1;
            string b2;
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Bölümü giriniz:");
                b1 = Console.ReadLine().ToString();
                b2 = Console.ReadLine().ToString();

                for (int j = 0; i < 6; j++)
                {
                    Console.Write("Öğrenci adını giriniz:");
                }
            }


            Console.ReadKey();
        }
    }
}
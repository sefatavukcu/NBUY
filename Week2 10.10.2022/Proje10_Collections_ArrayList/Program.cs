using System.Collections;

namespace Proje10_Collections_ArrayList
{
    internal class Program
    {
        static void yaz1(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {

            ArrayList sayilar = new ArrayList()
            {
                54,12,66,34,19
            };
            yaz1(sayilar);
            Console.WriteLine("************");
            sayilar.Sort();
            yaz1(sayilar);
            Console.WriteLine("************");
            sayilar.Reverse();
            yaz1(sayilar);




            //ArrayList myList = new ArrayList();  // Farklı tipte veriler tutabilir.
            //myList.Add(120);
            //myList.Add("120");
            //myList.Add("Zeynep");
            //myList.Add(11.5);
            //myList.Add(DateTime.Now);
            //myList.Add(true);

            //myList.Insert(0, "Yeni eleman");  // Araya ekler.

            //ArrayList addedList = new ArrayList()
            //{
            //    "Ayşen Umay",
            //    "Kazım Kolkanat",
            //    "Ali Tezcan"
            //};

            //myList.InsertRange(4, addedList);  // Listeyi ekler.
            //myList.AddRange(addedList);       // En sona ekler.

            //myList.Remove("Zeynep");    // Listeden siler.
            ////myList.RemoveAt(0);      // Listeden indexi siler.
            ////myList.RemoveRange(0,5);  // Listeden 0,5 arasını siler.

            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //if (myList.Contains("Zeynep")==true)
            //{
            //    Console.WriteLine("Evet Zeynep listede mevcut...");
            //}
            //else
            //{
            //    Console.WriteLine("Zeynep'e haber ver. Listede yok!!!");
            //}

            //Console.WriteLine();
            //Console.WriteLine(myList[3]);

            Console.ReadKey();
        }
        
    }
}
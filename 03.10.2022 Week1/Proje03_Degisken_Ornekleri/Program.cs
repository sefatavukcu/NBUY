namespace Proje03_Degisken_Ornekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 120;
            //int sayi2 = 189;
            //Console.WriteLine(sayi1 + "\n" + sayi2);  // \n alt satira yazar.
            //Console.WriteLine($"SAYI1: {sayi1}\nSAYI2: {sayi2}");  // $ işareti '+' işareti koymaya gerek bırakmaz. {} işaretini etkin hale getirir.
            //Console.WriteLine(sayi1+sayi2);  // toplam

            //string sayi3 = "150";
            //string sayi4 = "190";
            //Console.WriteLine(sayi3+sayi4);  // stringte + işareti metin birlestirmeye yarar.

            //int sayi5 = 150;
            //string sayi6 = "190";
            //Console.WriteLine(sayi5 + sayi6); // int ve string metin birlestirme.

            //int sayi7 = 859;
            //string sayi8 = "981";
            //Console.WriteLine(sayi7.ToString() + sayi8);  // int'ten stringe donusturme 

            //Console.WriteLine(sayi7 + Convert.ToInt32(sayi8));  // !!! string'ten int'e donusturme !!!

            // Kayar Noktalı Sayılar

            decimal sayi1 = 0.1m;     // double olunca sayi1 + sayi2 == sayi3 e esit olmaz  (double ondalık hassasiyet çok değil)
            decimal sayi2 = 0.7m;     // float olunca esit olur. (float daha hassas)
            decimal sayi3 = 0.8m;     // decimal olunca true verir. (parasal)
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi3);

            Console.WriteLine(sayi1+sayi2);
            Console.WriteLine((sayi1+sayi2)== sayi3);

        }
    }
}
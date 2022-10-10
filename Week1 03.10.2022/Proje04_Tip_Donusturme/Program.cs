namespace Proje04_Tip_Donusturme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte a = 5;
            //short b = 10;
            //sbyte c = 20;  // -127 -- 127 arası deger alır
            //int d = a + b + c;  // islem yapilirken atanacagi yer int oldugu icin ona donusturerek yapar. (Impicit Convert - Gizli (Ortulu) Donusturme)
            //Console.WriteLine($"Sonuç(d): {d}");

            //string metin = "NBUY";
            //char karakter = 'k';
            //object e = metin + karakter + d;  // object, ayırt etmeksizin ortak olarak kabul eder. (Her şey objecttir.)
            //Console.WriteLine($"object: {e}");  // Impicit convert

            // altı kırmızı çizgili hatalar : building error
            // uygulama çalıştığında çıkan hatalar : runtime error

            //byte a = 155;
            //byte b = 101;
            //byte c = Convert.ToByte(a + b);  // Explicit Convert (Bilincli Donusum)
            //Console.WriteLine($"Sonuç: {c}");

            //byte d = (byte)(a + b); // Çıkart ama byte olarak çıkar. (Unboxing)
            //Console.WriteLine($"Sonuç: {d}"); // Yazdırırken byte içine sığdırabildiği kadarını sığdırıyor. Kalanını (sığdıramadığını) yazıyor.

            //int a = 511;
            //byte b = (byte)a;   // byte olayını kavramak istersen araştır dene :)
            //Console.WriteLine(b);

            /*
            byte a = 155;
            byte b = 101;
            int c = a + b;
            Console.WriteLine($"Sonuç: {c}");
            */

            /*
            Convert.ToDouble(c);
            Convert.ToInt64(c);
            */

        }
    }
}
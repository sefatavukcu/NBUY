using System.Collections;

namespace Proje04_Sayisal_Loto_Oyunu
{

    internal class Program
    {

        static int[] SayiUret()
        {
            Random rastgeleSayi = new Random();
            int[] loto = new int[6];
            int sayi;
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    sayi = rastgeleSayi.Next(1, 50);
                } while (loto.Contains(sayi));

                loto[i] = sayi;

                
            }
            return loto;
        }

        static void Hile(int[] loto)
        {
            Console.WriteLine("HİLE");
            Console.WriteLine("****");

            foreach (var siradakiSayi in loto)
            {
                Console.WriteLine(siradakiSayi);
            }
        }

        static int TahminYap(int tahminSiraNo)  // Kullanıcının her tahmin yapışını burası sağlayacak.
        {
            int tahmin;
            Console.Write($"{tahminSiraNo}. Tahmininizi Giriniz: ");
            tahmin = int.Parse(Console.ReadLine());
            return tahmin;
        }

        static void Main(string[] args)
        {
            #region Açıklama
            // 1) Sistem 1-49 arasında 6 tane farklı sayı üretsin.
            // 2) Kullanıcıdan 6 tane tahmin alalım.
            // 3) Sonuç olarak kullanıcının kaç tane doğru tahmin yaptığını, tahminleriyle yazdıralım.
            // 4) Hiç doğru tahmin yapamazsa KAYBETTİNİZ yazsın.
            #endregion

            int[] loto = SayiUret();
            int[] tahminler = new int[6];
            Hile(loto);
            int tahmin;

            for (int i = 0; i < 6; i++)
            {
                do
                {
                    tahmin = TahminYap(i + 1);
                } while (tahmin<0 || tahmin>49);
                tahminler[i] = tahmin;
            }



            ArrayList bilinenler = new ArrayList();  // Arraylistler kaç elemanlı olacağı söylenmez. İçinde bir eleman istenilen tipte değer tutabilir, int, char, string vb.

            foreach (var siradakiTahmin in tahminler)
            {
                if (loto.Contains(siradakiTahmin))
                {
                    bilinenler.Add(siradakiTahmin);
                }
            }

            if (bilinenler.Count==0)       
            {
                Console.WriteLine("Kaybettin...");
            }
            else
            {
                Console.WriteLine($"Tebrikler... {bilinenler.Count} adet doğru tahmin yaptınız.");
                foreach (var siradakiBilinen in bilinenler)
                {
                    Console.WriteLine(siradakiBilinen);
                }
            }

            Console.ReadKey();
        }
    }      
}
namespace Proje08_Hata_Kontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                // Buraya normalde çalışması istenilen kodlar yazılır.
                // Try bloğunda herhangi bir hata var mı yok mu kontrol ediliyor.
                // Eğer hata var ise CATCH bloğuna gönderiliyor.
                // Hataları ön görüp kontrol altına alıyoruz.

                Console.Write("Birinci sayıyı giriniz:");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.Write("İkinci sayıyı giriniz:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                int sonuc = (sayi1 / sayi2);
                Console.WriteLine(sonuc);
            }
            catch (DivideByZeroException ex)    // Exception hata fırlatıyor. 
            {
                Console.WriteLine("0'a Bölünme Hatası oluştu.");
                //Console.WriteLine(ex.Message);
            }

            catch (OverflowException)
            {
                Console.WriteLine("Büyük bir sayı girdiniz!!!");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu!!!");

            }

            finally
            {
                // try ya da catch hangisi çalışırsa çalışsın, çalışmasını istediğimiz kodları buraya yazarız.
                Console.WriteLine("Program sona ermiştir.");
            }
        }
    }
}
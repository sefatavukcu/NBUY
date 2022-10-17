namespace Proje01_Class_Field_Property_Uygulama
{

    class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Product classımız olacak. Name, Price, Description
            // İstenildiği kadar product bilgisinin girilmesini sağlayacağız.
            // Kaç adet product bilgisi girileciğini kullanıcı belirlesin.
            // Product ekleme işi bitince, eklenmiş prductlar listelensn.


            //Console.Write("Kaç adet ürün gireceksin:");
            //int adet = int.Parse(Console.ReadLine());
            //Product[] products = new Product[adet];
            //Product product;

            //for (int i = 0; i < adet; i++)
            //{
            //    product = new Product();

            //    Console.Write("Product Name: ");
            //    product.Name = Console.ReadLine();

            //    Console.Write("Price: ");
            //    product.Price = decimal.Parse(Console.ReadLine());

            //    Console.Write("Description: ");
            //    product.Description = Console.ReadLine();

            //    products[i] = product;

            //}
            //Console.WriteLine("Product Name\tPrice\tDescription");
            //foreach (var prd in products)
            //{
            //    Console.WriteLine($"{prd.Name}\t{prd.Price}\t{prd.Description}");

            //}

            // Rastgele Değer Üreterek...

            Console.Write("Zam oranını giriniz: ");
            decimal zam = decimal.Parse(Console.ReadLine());
            decimal[] oldPrices = new decimal[5];
            Product[] products = new Product[5];
            Product product;
            string[] nameArray = { "Telefon", "Bilgisayar", "Monitör", "Mouse", "Adaptör" };
            int[] priceArray = { 1500, 3000, 2000, 8500, 500 };
            string[] descArray = { "İyi", "Kötü", "Kullanışlı", "Dayanıklı", "Kırılma Potansiyeli Yüksek" };
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                product = new Product()
                {
                    Name = nameArray[rnd.Next(0, 5)],
                    Description = descArray[rnd.Next(0, 5)],
                    Price = priceArray[rnd.Next(0, 5)] ,
                };
                oldPrices[i] = product.Price;
                product.Price = product.Price * (1+(zam/100));

                products[i] = product;

            }
            int j = 0;
            Console.WriteLine("Product Name".PadRight(30) + "Old Price".PadRight(30) + "New Price".PadRight(30) + "Description".PadRight(30));
            foreach (var prd in products)
            {
                Console.WriteLine(prd.Name.PadRight(30) + oldPrices[j].ToString().PadRight(30) + prd.Price.ToString().PadRight(30)+ prd.Description.PadRight(30));
                j++;
            }

            // Padright ve padleft sağa sola kaç satır kaydırarak yazdırmak istersen onu sağlar... stringlerde olur.


            /*
             * DENE BUNU KENDİ ALGORİTMANA GÖRE
             * 
            string[] name = {"Telefon","Bilgisayar","Monitör","Mouse","Adaptör"};
            int[] price = { 1500, 3000, 2000, 8500, 500 };
            string[] description = { "İyi", "Kötü", "Kullanışlı", "Dayanıklı", "Kırılma Potansiyeli Yüksek" };

            Console.Write("kaç adet ürün gireceksin:");
            int adet = int.Parse(Console.ReadLine());

            Random names = new Random();
            string rastgeleName = names.Next();

            Random prices = new Random();
            string rastgelePrice = prices.Next();

            Random descriptions = new Random();
            string rastgeleDesc = description.Next(1);

            for (int i = 0; i < 5; i++)
            {

            }
            */



        }
    }
}
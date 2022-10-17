namespace Proje11_Collections_GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion



            /*
           

            // Eğer herhani bir şeyin yanında <> var ise generic yapıdadır.
            List<int> sayilar = new List<int>();
            sayilar.Add(17);
            sayilar.Add(134);
            sayilar.Add(35);
            sayilar.Add(59);
            sayilar.Add(218);

            List<string> isimler = new List<string>();
            isimler.Add("Ali");
            isimler.Add("Begüm");
            isimler.Add("Cansu");

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine();
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine();
            sayilar.Sort();
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            */


            //Product product1 = new Product()
            //{
            //    Id = 1,
            //    Name="Telefon",
            //    Price = 28000
            //};
            //Product product2 = new Product()
            //{
            //    Id = 2,
            //    Name = "Bilgisayar",
            //    Price = 35000
            //}; Product product3 = new Product()
            //{
            //    Id = 3,
            //    Name = "Monitor",
            //    Price = 15000
            //};

            //List<Product> products = new List<Product>()
            //{
            //    product1, product2, product3
            //};

            //List<Product> products = new List<Product>();
            //products.Add(product1);
            //products.Add(product2);
            //products.Add(product3);

            // İleride ihtiyacımız olmayacağı zaman yapılabilir...

            //List<Product> products = new List<Product>()
            //{
            //    new Product(){Id=1, Name="Telefon", Price=19000},
            //    new Product(){Id=1, Name="Bilgisayar", Price=27000},
            //    new Product(){Id=1, Name="Monitör", Price=13000},
            //};

            // Yeni bir liste yaratın. Adı da newProducts olsun. İçine yukarıdaki gibi 3 yeni ürün bilgisi girin.

            //List<Product> newProducts = new List<Product>()
            //{
            //    new Product(){Id=4, Name="Tablet", Price=5000},
            //    new Product(){Id=5, Name="Çamaşır Makinesi", Price=15000},
            //    new Product(){Id=6, Name="Buzdolabı", Price=14500},
            //};

            // new products içindeki productları, products içine ekleme

            //products.AddRange(newProducts);

            // ArrayListlere özgü foreach...

            //products.ForEach(product => {
            //    Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            //    Console.WriteLine();
            //});

            //int elemanSayisi = products.Count; // Parantezsiz count, tanımlanan listedekini hesaplar.

            //products.Insert(0, new Product() { Id = 20, Name = "Masa", Price = 3500 });

            //products.InsertRange(3, newProducts);  


            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            //    Console.WriteLine();
            //}

            //List<Product> products = new List<Product>()
            //{
            //    new Product(){Id=4, Name="Tablet", Price=5000},
            //    new Product(){Id=5, Name="Çamaşır Makinesi", Price=15000},
            //    new Product(){Id=6, Name="Buzdolabı", Price=14500},
            //};

            //ProductModel productModel = new ProductModel()
            //{
            //    Id = 1,
            //    CategoryName = "First Category",
            //    Products = products
            //};

            //Console.WriteLine(productModel.Id);
            //Console.WriteLine(productModel.CategoryName);
            //foreach (var product in productModel.Products)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(product.Name);
            //}

            #endregion

            // İçinde 3 adet ProductModel tipinde veri barındıran bir list oluşturun.
            // Her bir product model içinde ise, Products özelliğinde 3er adet Product koyun.

            List<ProductModel> productsModels = new List<ProductModel>()
            {
                new ProductModel(){Id=1, CategoryName="Telefonlar", Products=new List<Product>()
                {
                    new Product(){Id=1, Name="IPhone 13 Pro", Price= 32000},
                    new Product(){Id=2, Name="Samsung", Price= 30000},
                    new Product(){Id=3, Name="Xiaomi", Price= 28000}
                }
                },

                new ProductModel(){Id=1, CategoryName="Telefonlar", Products=new List<Product>()
                {
                    new Product(){Id=11, Name="IPhone 13 Pro", Price= 32000},
                    new Product(){Id=21, Name="Samsung", Price= 30000},
                    new Product(){Id=31, Name="Xiaomi", Price= 28000}
                }
                },

                new ProductModel(){Id=1, CategoryName="Telefonlar", Products=new List<Product>()
                {
                    new Product(){Id=12, Name="IPhone 13 Pro", Price= 32000},
                    new Product(){Id=22, Name="Samsung", Price= 30000},
                    new Product(){Id=32, Name="Xiaomi", Price= 28000}
                }
                },
            };

            foreach (var productModel in productsModels)
            {
                Console.WriteLine($"{ productModel.Id}  {productModel.CategoryName} ");
                foreach (var product in productModel.Products)
                {
                    Console.WriteLine($"{product.Id}  {product.Name}  {product.Price}");
                }
            }

            Console.ReadKey();
        }
    }
}
namespace Proje09_Interface
{
    // Interfaceler için belirtilmediğinde default erişim belirleyici publictir.
    // Interfaceler protected private ya da static olarak işaretlenemezler.
    // Interfaceler içinde çalışabilir kodlar olamaz. Yani metotların sadece imzası olur.
    // Bir interface, bir ya da daha çok interfaceden miras alabilirler.
    // Bir interface classtan miras alamaz.
    // Eğer bir class bir interfaceden miras alıyorsa miras aldığı interfacedeki tüm metotları implemente etmek zorundadır.
    // (Implemente : miras alınan interfacede imzası bulunan tüm metotların, içi dolu halleri...)
      
      
    interface IPersonel
    {
        public string Departman { get; set; }
    }
    interface IKisi // Interface de birden fazla miras alınabilir.......
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string  Maas { get; set; }
        public void Bilgi(); // Interfaceler içindeki metotlarda sadece imza bulunur. Methodun gövdesi olmaz! 
        // Methodun gövdesi, bu interfacei miras alan class içinde doldurulur.
        // Interface new yapılamaz...
    }

    class Yonetici : IKisi, IPersonel // İnterfacedeki her şey buraya yazılır. Implemented.
    {
        /// <summary>
        /// Bu method herhamgi bir yönetici bilgisi girmeden yönetici oluşturur.
        /// </summary>
        ///
        public Yonetici()
        {
            // Kimi zaman AdSoyad, Adres, Maaş ve Departman bilgisini vermeden de Yönetici oluşturmak istediğimiz zaman çalışır.
        }
        public Yonetici(string adSoyad, string adres, string maas, string departman)
        {
            AdSoyad = adSoyad;
            Adres = adres;
            Maas = maas;
            Departman = departman;
        }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public string Departman { get; set; } 

        public void Bilgi()
        {
            throw new NotImplementedException();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir abstract classtan, miras alan classta eğer base classta abstract bir method varsa, mutlaka override edilmeli
            // Eğer base classta abstract olmayan methodlar varsa, onlar aynen kullanılabilir
            // Ancak bazen, miras alınan classtaki her metodun, içinin dolu hallerini yazmak zorunlu olsun isteriz.
            // yani bir nevi hepsi abstract olsun isteriz. Yani bunu yapmak yerine, miras alınan class, class değil
            // INTERFACE olarak tanımlanır!!!!

            //IPersonel personel = new IPersonel(); // Hatalı kullanım!


            //Yonetici yonetici1 = new Yonetici();
            //Yonetici yonetici2 = new Yonetici("fjjf", "sdhds", "jsjdj", "kjdssdkj");

            Product product1 = new Product()
            {
                Id = 1,
                Name = "IPhone 13 Pro Max",
                Price = 36000,
                Properties = "16 GB Ram",
                Ratio = 0.5m,
                CreatedDate = DateTime.Now
            };

            Console.WriteLine($"Product Name: {product1.Name} (Büyük Harfli: {product1.Name.ToUpper()}) Properties: {product1.Properties}");

            Category category1 = new Category()
            {
                Id = 1,
                Name = "Telefon",
                CreatedDate = DateTime.Now,
                Description = "Bu kategori telefonlar içindir."
            };

            Console.WriteLine($"Category Name: {category1.Name} (Büyük Harfli: {category1.Name.ToUpper()}) Description: {category1.Description}");


            Console.ReadKey();
        }
        
    }
}
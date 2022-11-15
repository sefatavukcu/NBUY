using Proje01;
using Proje01.efcore;

//NorthwindContext context = new NorthwindContext();
// //customer listesi alıyor.
// List<Customer> customers = context.Customers.ToList();
// // customerse erişir ve listeye atar.
// foreach (var customer in customers)
// 	{
// 		Console.WriteLine(customer.CompanyName);
// 	}

// London da yaşayan customer listesi

// List<Customer> customers = context.Customers.Where(c=>c.City=="London").ToList();
// foreach (var customer in customers)
// {
// 	System.Console.WriteLine(customer.CompanyName + " --- " + customer.City);
// }

// Londonda yaşayan customerların sadece companyName ve contactname getiriniz.
// var = anonim tipten bir liste oluşturduğumuz için kullandık.
// var customers = context
// 	.Customers
// 	.Select(c=>new {c.CompanyName,c.ContactName,c.City})
// 	.Where(c=>c.City=="London")
// 	.ToList();
// foreach (var customer in customers)
// {
// 	System.Console.WriteLine(customer.CompanyName + " --- " + customer.ContactName + " --- " + customer.City);
// }

// Londonda yaşayan customerların sadece companyName ve contactname getiriniz.
// Nesne kullanarak:

// List<CustomerModel> customers = context
// 	.Customers
// 	.Select(c=>new CustomerModel() {
// 		CompanyName = c.CompanyName,
// 		ContactName = c.ContactName,
// 		City =c.City})
// 	.Where(c=>c.City=="London")
// 	.ToList();
// foreach (var customer in customers)
// {
// 	System.Console.WriteLine(customer.CompanyName + " --- " + customer.ContactName + " --- " + customer.City);
// }


// class CustomerModel
// {
// 	public string? CompanyName { get; set; }
// 	public string? ContactName { get; set; }
// 	public string? City { get; set; }
// }

// bevarages categorisindeki ürünlerin listesi

// var bevaragesProduct = context
// 	.Products
// 	.Where(p=>p.Category.CategoryName=="Beverages")
// 	.ToList();
// foreach (var p in bevaragesProduct)
// {
// 	System.Console.WriteLine(p.ProductName);
// }

// Suppliers tablosundaki germany de yaşayanları listeleyin

// var livingGermany = context
// 	.Suppliers
// 	.Where(S=>S.Country=="Germany")
// 	.ToList();
// foreach (var s in livingGermany)
// {
// 	System.Console.WriteLine(s.Country);
// }

// Nancy adlı çalışanın yaptığı satışlar

// var NancySell = context
// 	.Orders
// 	.Where(o=>o.Employee.FirstName=="Nancy" && o.ShipCountry=="Brazil")
// 	.ToList();
// foreach (var p in NancySell)
// {
// 	System.Console.WriteLine(p.OrderId);
// }
// System.Console.WriteLine("Toplam satış sayısı:" + NancySell.Count());

//productları ıd ye göre büyükten küçüğe sıralı bir şekilde sıralayalım
// var products =context
//     .Products
//     .OrderByDescending(p=>p.ProductId)//büyükten üçüğe sıraladık
//     .ToList();

// foreach (var p in products)
// {
//     System.Console.WriteLine(p.ProductId+" ---"+p.ProductName);
// }

//en son satılan 5 ürünü listeleyelim
// var products =context
//     .Products
//     .OrderByDescending(p=>p.ProductId)//büyükten üçüğe sıraladık
//     .Take(5)//ilk 5 kaydı gösteriri sql deki TOP gibi
//     .ToList();

// foreach (var p in products)
// {
//     System.Console.WriteLine(p.ProductId+" ---"+p.ProductName);
// }

//fiyatı 10 ile 20 arasında olan ürünlerin adını ve fiyatını getirip listeleyelim,fiyata göre küçükten büyüğe sıralayalım
// var products =context
//     .Products
//     // .Select(p=>new{ // select satırını yazmadığımız zaman bütün kolonları arkada getiriyordu ve biz içinde çağırıyorduk şimdi ise select ile hangi kolonları getireceğimizi seçiyoruz fazla olan kolonları getirmiyoruz bizim işimize yarayan kolonları getirdik
//     //     p.ProductName, // select where den öncede olur whereden sonrada olur
//     //     p.UnitPrice   // fakat burada unitPrice yazmasak yani sadece product name ni istesek where koşulu hata verirdi o yüzden duruma göre aşşağıda kullanmak gerekebilir
//     // })
//     .Where(p=>p.UnitPrice>=10 && p.UnitPrice<=20)  
//      .Select(p=>new{ // select satırını yazmadığımız zaman bütün kolonları arkada getiriyordu ve biz içinde çağırıyorduk şimdi ise select ile hangi kolonları getireceğimizi seçiyoruz fazla olan kolonları getirmiyoruz bizim işimize yarayan kolonları getirdik
//         p.ProductName,
//         p.UnitPrice
//     })
//      .OrderBy(p=>p.UnitPrice)// küçükten büyüğe sıraladık
//     .ToList();//execute eden kısım burası

// foreach (var p in products)
// {
//     System.Console.WriteLine(p.ProductName+" --->"+p.UnitPrice);
// }


//beverages kategorsiindeki ortalama fiyatını ekrana yazdıralım
// var ortalama=context
//     .Products
//     .Where(p=>p.Category.CategoryName=="Beverages")
//     .Average(p=>p.UnitPrice);//ortalamayı alır

//   System.Console.WriteLine("Beverages fiyat ortalaması {0}",ortalama);  


// //Beverages kategorisindeki ürün adedi
// var adet=context
//     .Products
//     // .Where(p=>p.Category.CategoryName=="Beverages")
//     // .Count();
//     .Count(p=>p.Category.CategoryName=="Beverages"); // üstteki 2 satırın aynısı ama kısası where gerek yok

//   System.Console.WriteLine("Beverages  kategorsiindeki adet {0}",adet);  

//Beverages ve condiments kategorilerinde toplam kaç adet ürün vardır
// var adet=context
//     .Products
//     .Where(p=>p.Category.CategoryName=="Beverages" || p.Category.CategoryName=="Condiments")
//     .Count();

//   System.Console.WriteLine("Beverages  kategorsiindeki adet {0}",adet);  


  //adının içinde tofu geçenleri listeleyelim
//   var products=context
//     .Products
//     .Where(p=>p.ProductName.Contains("tofu"))
//     .ToList();
// foreach (var p in products)
// {
//     System.Console.WriteLine(p.ProductName);
// }


//en ucuz ve en pahalı ürün hangileri
// var minPrice=context.Products.Min(p=>p.UnitPrice);
// var maxPrice=context.Products.Max(p=>p.UnitPrice);

// var minProduct=context
//     .Products
//     .Where(p=>p.UnitPrice==minPrice)
//     .Select(p=>new{
//         p.ProductName,
//         p.UnitPrice
//     }).FirstOrDefault();// bunun yerine to list yazsaydık console.write içinde yazmamız zordu veya döngü yapıp yazdırmamız gerekirdi ama biz bir değer döndürüceğimiz için FirstOrDefault bu değişkeni kullandık
// // eğer aynı fiyatta birden fazla değer olsaydı tolist kullanmamız daha mantıklı çünkü  FirstOrDefault bu değişken yukarıdan karşılaştığı il değeri getirir
// var maxProduct = context
// .Products
// .Where(a=>a.UnitPrice==maxPrice)
// .Select(muslera=> new {
// 	muslera.ProductName,
// 	muslera.UnitPrice
// }).FirstOrDefault();

// System.Console.WriteLine($"MinPrice {minPrice} -->Product:{minProduct.ProductName} {minProduct.UnitPrice}");
// System.Console.WriteLine($"MaxPrice {maxPrice} -->Product:{maxProduct.ProductName} {maxProduct.UnitPrice}");

// En düşük fiyatlı ürünler ve fiyatları
// En yüksek fiyatlı ürünler ve fiyatları

// var minPrice=context.Products.Min(p=>p.UnitPrice);
// var maxPrice=context.Products.Max(p=>p.UnitPrice);

// var minProduct=context
//     .Products
//     .Where(p=>p.UnitPrice==minPrice)
//     .Select(p=>new{
//         p.ProductName
//     }).ToList();
// 	foreach (var p in minProduct)
// 	{
// 		System.Console.WriteLine($"MinPrice {minPrice} --> Product:{p.ProductName}");
// 	}

// var maxProduct = context
// 	.Products
// 	.Where(a=>a.UnitPrice==maxPrice)
// 	.Select(muslera=> new {
// 		muslera.ProductName
// 	}).ToList();

// 	foreach (var p in maxProduct)
// 	{
// 		System.Console.WriteLine($"MaxPrice {maxPrice} --> Product:{p.ProductName}");
// 	}

var mt = new MultiTable();
//mt.MusteriSayisi();
//mt.SatisYapilanMusteriler();
//mt.SatisYapilmayanMusteriler();
mt.MusteriSatisListesi();

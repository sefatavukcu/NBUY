namespace Proje07_Constructor_Methods
{
    class Person
    {
        public Person() // Method, constructor Method tipi olmazz.!!!
        {
            // Her class ın default olarak boş bir constructor methodu vardır, ama implicittir, yani örtülü, gizlidir.
            // Şu anda biz kendimizi bir constructor method yazdık!
            // Constructor method, ilgili classtan new keywordu ile yeni bir nesne yaratıldığı esnada çalışacak kodları barındırır.
            // Yani bu classtan bir nesne üretildiği anda buradakikodlar çalışıyor...
            Console.WriteLine("oluşturuluyor");
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Student : Person  // Constructor miras verilen sınıfta kullanılmaz, sadece tanımlanan sınıfta kullanılır.
    {
        public Student(string firstname, string lastname, int studentnumber):base(firstname, lastname)
        {    // base = miras aldığı classtaki propa gönderir ve orada çalışır.
            //FirstName = firstName;
            //LastName = lastName;
            StudentNumber = studentnumber;
        }
        public int StudentNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person();
            //Person person2 = new Person("Sefa", "Tavukçu");
            //Console.WriteLine($"{person2.FirstName} {person2.LastName}");

            Student student1 = new Student("Selin", "Candaş", 182);
            Console.WriteLine($"{student1.FirstName} {student1.LastName} {student1.StudentNumber}");
            Console.ReadKey();
        }
    }
}
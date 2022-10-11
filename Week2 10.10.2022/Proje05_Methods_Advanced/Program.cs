using System.Collections;

namespace Proje05_Methods_Advanced
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public string Intro() 
            {
                return $"Ad: {this.Name}, Yaş: {this.CalculateAge()}";  // This : class person içindeki name değil main içindeki tanımlananı çağırır.
            }
            private int CalculateAge()
            {
                return DateTime.Now.Year - this.Year;
            }

        }

        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Sefa", Year = 2000};
            Person person2 = new Person() { Name = "Ali", Year = 1995};
            Person person3 = new Person() { Name = "Ceyhun", Year = 1987};
            Person person4 = new Person() { Name = "Gülçin", Year = 2003};
            Person person5 = new Person() { Name = "Ayşen", Year = 1998};

            //Console.WriteLine(person3.Intro());
            // Tüm kişilerin intro bilgilerini ekrana yazdır.

            Person[] persons = { person1, person2, person3, person4, person5 };

            foreach (var person in persons)
            {
                Console.WriteLine(person.Intro());
            }

            Console.ReadKey();

            // C# ta her şey bir nesnedir!!!
        }
    }
}
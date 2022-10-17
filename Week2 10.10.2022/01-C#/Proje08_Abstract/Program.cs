namespace Proje08_Abstract
{
    abstract class Person // Eğer bir class abstract ise, o classtan yeni nesne yaratılmaz............
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("Person is created.");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public void Greeting()
        {
            Console.WriteLine("I am a person.");
        }
        public abstract void Intro(); // Soyut Methodu 
        // Eğer bir classın içinde abstract method varsa, o class da abstract olmalı!!!
    }
    class Student : Person
    {
        public Student(string firstName, string lastName, int studentNumber) : base(firstName, lastName)
        {
            studentNumber = StudentNumber;
            Console.WriteLine("Student is created.");
        }
        public int StudentNumber { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name: {this.FirstName}, Last Name: {this.LastName}, Student Number: {this.StudentNumber}");
        }
    }
    class Teacher:Person
    {
        public Teacher(string firstName, string lastName, string branch) : base(firstName,lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Branch = branch;
        }

        public string Branch { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name: {this.FirstName}, Last Name: {this.LastName}, Branch: {this.Branch}");
        }

        public void Teach()
        {
            Console.WriteLine("Hi, I'm teaching.");
        }
    }
    class Writer:Person
    {
        public Writer(string firstName, string lastName, string bookName) : base(firstName, lastName)
        {

        }
        public string BookName { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name: {this.FirstName}, Last Name: {this.LastName}, Book Name: {this.BookName}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Gülper","Özden",912);
            student1.Greeting();
            student1.Intro(); // İstemediğimiz halde persondaki intro çalışıyor...

            Teacher teacher1 = new Teacher("Maria", "Korkut", "French");
            teacher1.Greeting();
            teacher1.Intro();  // İstemediğimiz halde persondaki intro çalışıyor...

            Writer writer1 = new Writer("Math","Haig","Gece Yarısı Kütüphanesi");
            writer1.Greeting();
            writer1.Intro();

            //Person person1 = new Person("Halil", "Kansız"); // abstract olduğu için new kullanılmaz!!!
            
            Console.ReadKey();
        }
    }
}
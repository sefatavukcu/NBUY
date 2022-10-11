namespace Proje06_Inheritance_Kalitim
{

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void Intro()  // virtual : Bu metodun miras alınan classlarda override edilmesine izin verir.
        {
            Console.WriteLine($"Name: {this.FirstName}, LastName: {this.LastName}");
        }

    }
    // Bir class sadece tek bir classtan miras alabilir...(interface ile yapılabilir!!"Soyutlama")
    // Bir class istenildiği kadar başka classa miras verebilir.
    class Student : Person   // :Person ========    Persondan kalıtım ile onları alır.
    {
        public int StudentNumber { get; set; }
        public override void Intro()    // override : Bu metodun miras alınan sınıftaki versiyonunu ezip, yok sayıp yerine bu metodu kabul eder.
        {
            Console.WriteLine($"Name: {this.FirstName}, LastName: {this.LastName}, Student Number: {this.StudentNumber}");
        }
    }
    class Writer : Person
    {
        public string BookName { get; set; }
    }
    class Teacher:Person
    {
        public string Branch { get; set; }
        public override void Intro()
        {
            Console.WriteLine($"Name: {this.FirstName}, LastName: {this.LastName}, Branch: {this.Branch}");
        }
    }
    class a
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
    class b:a
    {
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }
    }
    class c:b   // Hiyerarşik bir biçimde oluşan kalıtım... c classı a'dan da miras alabilir...
    {
        public int MyProperty5 { get; set; }  
        public int MyProperty6 { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person();
            Student student = new Student();
            student.FirstName = "Kemal";
            student.LastName = "Kapucu";
            student.StudentNumber = 182;
            student.Intro();


            // Bir teacher tanımlayın ve içini doldurun.

            Teacher teacher = new Teacher();
            teacher.FirstName = "Ayşe";
            teacher.LastName = "Demir";
            teacher.Branch = "İngilizce";
            teacher.Intro();


            Person person1 = new Student();    // person student olarak tanımlanabilirken...
            //Student student1 = new Person();  // Student person olarak tanımlanamıyor...
              
            Console.ReadKey();
        }
    }
}
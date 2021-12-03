namespace OOP;
class Student
{
    readonly string university = "BSU";
    const int years = 4;
    private static int counter = 0;
    public static void DisplayCounter()
    {
        Console.WriteLine($"Создано {counter} объектов Student");
    }

    public string name = "Undefined";
    public string Name { set; get;}
    public int age = 18;
    public int Age
    {
        set  
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть больше 17");
            }
            else
            {
                age = value;
            }
        }
        get { return age; }
    }
    private double evMarks;
    public double EvMarks
    {
        set  
        {
            if (value > 10)
            {
                Console.WriteLine("Средний балл должен быть меньше 10");
            }
            else if (value <= 0)
                {
                Console.WriteLine("Средний балл должен быть больше 0");
            }
            else
            {
                evMarks = value;
            }
        }
        get { return age; }
    }

    public Student() { name = "Undefined"; age = 18; evMarks = 5; counter++; }
    public Student(string a, string b) { name = a; age = 18; evMarks = 5; university = b; counter++; }
    public Student(string a, int b, int c) { name = a; age = b; evMarks = c; counter++; }
    public void Marks()
    {
        Console.WriteLine("Введите средний балл");
        evMarks = Convert.ToDouble(Console.ReadLine());
    }
    public void Print()
    {
        Console.WriteLine($"Имя - {name}, возраст - {age}, средний балл - {evMarks}, университет - {university}, количество лет обучения - {years}");
    }
}
struct StudentStruct
{
    public string name;
    public int age;
    public double evMarks;
    public StudentStruct(string a, int b, int c) { name = a; age = b; evMarks = c; }
    public void Marks()
    {
        Console.WriteLine("Введите средний балл");
        evMarks = Convert.ToDouble(Console.ReadLine());
    }
    public void Print()
    {
        Console.WriteLine($"Имя - {name}, возраст - {age}, средний балл - {evMarks}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student Bill = new Student();
        Bill.Marks();
        Bill.name = "Bill";
        Bill.Print();
        Student Sten = new Student("Sten", "BSMU");
        Sten.Print();
        StudentStruct Advard = new StudentStruct();
        Advard.Print();
        Advard.name = "Advard";
        Advard.age = 5;
        Advard.Print();
        StudentStruct Dan = new StudentStruct("Dan", 5, 5);
        Dan.Print();
        Student.DisplayCounter();
    }
}
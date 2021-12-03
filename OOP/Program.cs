namespace OOP;
class Student
{
    public string name = "Undefined";
    public string Name
    {
        set { name = value; }
        get { return name; }
        }
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

    public Student() { name = "Undefined"; age = 18; evMarks = 5; }
    public Student(string a) { name = a; age = 18; evMarks = 5; }
    public Student(string a, int b, int c) { name = a; age = b; evMarks = c; }
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
        Student Sten = new Student("Sten");
        Sten.Print();
        StudentStruct Advard = new StudentStruct();
        Advard.Print();
        Advard.name = "Advard";
        Advard.age = 5;
        Advard.Print();
        StudentStruct Dan = new StudentStruct("Dan", 5, 5);
        Dan.Print();
    }
}
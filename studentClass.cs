Student student1 = new Student();
Student student2 = new Student("Mustafa Fatih");
Student student3 = new Student("Mustafa Fatih", "Çolakel");
Student student4 = new Student("Mustafa Fatih", "Çolakel", 18);
student1.ShowInfo();
System.Console.WriteLine("----------------");
student2.ShowInfo();
System.Console.WriteLine("----------------");
student3.ShowInfo();
System.Console.WriteLine("----------------");
student4.ShowInfo();
System.Console.WriteLine("----------------");

class Student
{
    public string Name;
    public string Surname;
    public int Age;

    public Student()
    {
        Name = "Bilinmiyor";
        Surname = "Bilinmiyor";
        Age = 18;
    }

    public Student(string name)
    {
        Name = name;
        Surname = "Bilinmiyor";
        Age = 18;
    }
    public Student(string name, string surname)
    {
        Name = name;
        Surname = surname;
        Age = 18;
    }

    public Student(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;

    }
    public void ShowInfo()
    {
        System.Console.WriteLine($"Ad: {Name}");
        System.Console.WriteLine($"Soyad:{Surname}");
        System.Console.WriteLine($"Age:{Age}");
    }
}
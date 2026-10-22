//! class       → şablon oluşturur
//* new         → nesne oluşturur
//* object      → class'tan oluşturulan nesne
//* field       → nesnenin verisi
//* method      → nesnenin yaptığı işlem
//* public      → dışarıdan erişilebilir

// Person person1 = new Person();

// Console.Write("Please your name ->");
// person1.Name = Console.ReadLine();
// Console.Write("Please enter your age ->");
// person1.Age = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter your depertmant ->");
// person1.depertmant = Console.ReadLine();


// Console.WriteLine($"Your name is {person1.Name} , and your age is {person1.Age} ,and your department is {person1.Departmant}.");
// person1.SayHello();


// Person person1 = new Person("Mustafa", 18, "Software Engineering");

// Console.WriteLine($"Your name is {person1.Name}, your age is {person1.Age}, and your department is {person1.Departmant}.");

// person1.SayHello();

// class Person
// {
//     public string Name;
//     public int Age;
//     public string Departmant;
//     public Person(string name, int age, string departmant)
//     {
//         Name = name;
//         Age = age;                   //? Constructor !!!
//         Departmant = departmant;
//     }
//     public void SayHello()
//     {
//         Console.WriteLine($"Hello,my name is {Name}! ");
//     }
// }



// Console.Write("Please enter your name -> ");
// string name = Console.ReadLine();

// Console.Write("Please enter your age -> ");
// int age = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter your department -> ");
// string department = Console.ReadLine();

// Person person1 = new Person(name, age, department);

// Console.WriteLine($"{person1.Name} - {person1.Age} - {person1.Department}");


// class Person
// {
//     public string Name;
//     public int Age;
//     public string Department;

//     public Person(string name, int age, string department)
//     {
//         Name = name;
//         Age = age;
//         Department = department;
//     }
// }

// Console.Write("Please enter your name ->");
// string name = Console.ReadLine();
// Console.Write("Please enter your age ->");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter your Department ->");
// string department = Console.ReadLine();

// Personel personel1 = new Personel(name, age, department);

// personel1.ShowInfo();
// class Personel
// {
//     public string Name;
//     public int Age;
//     public string Departmant;

//     public void Personel(string name, int age, string departmant)
//     {
//         Name = name;
//         Age = age;
//         Departmant = departmant;
//     }


//     public void ShowInfo()
//     {
//         Console.WriteLine($"Name :{Name}");
//         Console.WriteLine($"Age :{Age}");
//         Console.WriteLine($"Department :{Departmant}");
//     }

// }




// Console.Write("Please enter your name ->");
// string name = Console.ReadLine();

// Console.Write("Please enter your age ->");
// int age = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter your Department ->");
// string department = Console.ReadLine();

// Personel personel1 = new Personel(name, age, department);

// personel1.ShowInfo();


// class Personel
// {
//     public string Name;
//     public int Age;
//     public string Department;

//     public Personel(string name, int age, string department)
//     {
//         Name = name;
//         Age = age;
//         Department = department;
//     }

//     public void ShowInfo()
//     {
//         Console.WriteLine($"Name : {Name}");
//         Console.WriteLine($"Age : {Age}");
//         Console.WriteLine($"Department : {Department}");
//     }
// }




// Person ahmet = new Person();

// Console.Write("Please enter your age ->");
// ahmet.Age = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine(ahmet.Age);

// class Person
// {
//     private int age;
//     public int Age
//     {
//         get { return age; }
//         set
//         {
//             if (value >= 18)
//             {
//                 age = value;
//                 Console.WriteLine($"Your age is {age}.");
//             }
//             else
//             {

//             }
//         }
//     }
// }




// Student student1 = new Student();


// Console.Write("Please enter your name ->");
// student1.Name = Console.ReadLine();

// Console.Write("Please enter your age ->");
// student1.Age = Convert.ToInt32(Console.ReadLine());

// student1.ShowInfo();



// class Student
// {
//     public string Name;

//     private int age;

//     public int Age
//     {
//         get { return age; }

//         set
//         {
//             if (value >= 0)
//             {
//                 age = value;
//             }
//         }
//     }

//     public void ShowInfo()
//     {
//         Console.WriteLine($"Your {Age} years old ! ");
//         Console.WriteLine($"Your naem is {Name} ! ");
//     }
// }





// System.Console.Write("Please enter first number->");
// int num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("İf you wanna contunie enter a key !");

// Console.ReadKey();
// System.Console.Write("Please enter second number ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = num1 + num2;
// System.Console.WriteLine($"The result = {result} ");




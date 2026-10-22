
System.Console.Write("Please enter your school name -> ");
string okul = Console.ReadLine();

System.Console.Write("Please enter your name -> ");
string ad = Console.ReadLine();

System.Console.Write("Please enter your surname -> ");
string soyad = Console.ReadLine();

System.Console.Write("Please enter your vize result -> ");
int vize = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Please enter your final result -> ");
int final = Convert.ToInt32(Console.ReadLine());




student student1 = new student(ad, soyad, vize, final, okul);


//* 1-> öğrenci bilgi 
//* 2-> ortalama 
//* 3-> okulu
//* 4-> çıkış
System.Console.WriteLine("1 for Student İnformation ");
System.Console.WriteLine("2 for GNA");
System.Console.WriteLine("3 for Which school ");
System.Console.WriteLine("4 for Exit");

while (true)
{
    System.Console.Write("Please enter operation number (1,2,3,4) ->");
    int operation = Convert.ToInt32(Console.ReadLine());

    if (operation == 1)
    {
        student1.ShowStudentInformation();
    }
    else if (operation == 2)
    {
        student1.findStudentGNA();
    }
    else if (operation == 3)
    {
        student1.GetSchool();
    }
    else if (operation == 4)
    {
        System.Console.WriteLine("You are quiting the website are you sure (Yes/No) -> ");
        string answer = Console.ReadLine();
        if (answer.ToLower() == "yes")
        {
            System.Console.WriteLine("Website was quited ! ");
            break;
        }
        else
        {
            System.Console.WriteLine("You are continue !");
            continue;
        }
    }
    else
    {
        System.Console.WriteLine("Please enter the number betwen 1 and 4");
    }
}
class student
{
    //? Değişkenler
    private string name;
    private string surname;
    private int vize;
    private int final;
    private string schoolName;


    //? Construcator
    public student(string Name, string SurName, int Vize, int Final, string SchoolName)
    {
        name = Name;
        surname = SurName;
        vize = Vize;
        final = Final;
        schoolName = SchoolName;
    }

    //? metod 
    //* void yerine string veya int kullanırsak hata alırız . 
    //* return kullanmak için veri tipini belirmemiz gerekir . 
    //* Void kullanırsak böyle birşeye gerek kalmaz 
    //* voidde Console.Write kullanırız !
    public void ShowStudentInformation()
    {
        System.Console.WriteLine($"Name : {name}");
        System.Console.WriteLine($"Surname : {surname}");
        System.Console.WriteLine($"School name : {schoolName}");
    }

    public void findStudentGNA()
    {
        System.Console.WriteLine($"Ortalama : {vize * 0.4 + final * 0.6}");
    }

    public void GetSchool()
    {
        System.Console.WriteLine($"School : {schoolName}");
    }
}

// Console.Write("Please enter color of car -> ");
// string color = Console.ReadLine();

// Console.Write("Please enter how many door your car have -> ");
// int numberofDoor = Convert.ToInt32(Console.ReadLine());



// araba fiat = new araba(color, numberofDoor);

// System.Console.WriteLine(fiat.arabaRengi);
// System.Console.WriteLine(fiat.kapıSayısı);
// System.Console.WriteLine(fiat.motoruÇalıştır());
// System.Console.WriteLine(fiat.kapılarıKapat());
// class araba
// {
//     public string arabaRengi; //*property
//     public int kapıSayısı;   //*property

//     public string kapılarıKapat() //* method
//     {
//         return $"{kapıSayısı} tane kapı kapandı";
//     }

//     public string motoruÇalıştır()

//     {
//         return "Motor Çalıştı ";
//     }


//     public araba(string ArabaRengi, int KapıSayısı) //? Constructor 
//     {
//         arabaRengi = ArabaRengi;
//         kapıSayısı = KapıSayısı;
//     }



// }


// System.Console.Write("Please enter your school name -> ");
// string okul = Console.ReadLine();

// System.Console.Write("Please enter your name -> ");
// string ad = Console.ReadLine();

// System.Console.Write("Please enter your surname -> ");
// string soyad = Console.ReadLine();

// System.Console.Write("Please enter your vize result -> ");
// int vize = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Please enter your final result -> ");
// int final = Convert.ToInt32(Console.ReadLine());




// student student1 = new student(ad, soyad, vize, final, okul);


// //* 1-> öğrenci bilgi 
// //* 2-> ortalama 
// //* 3-> okulu
// //* 4-> çıkış


// while (true)
// {
//     System.Console.WriteLine("Please enter operation number (1,2,3,4) ->");
//     int operation = Convert.ToInt32(Console.ReadLine());

//     if (operation == 1)
//     {
//         student1.ShowStudentInformation();
//     }
//     else if (operation == 2)
//     {
//         student1.findStudentGNA();
//     }
//     else if (operation == 3)
//     {
//         student1.GetSchool();
//     }
//     else if (operation == 4)
//     {
//         System.Console.WriteLine("You are quiting the website are you sure (Yes/No) -> ");
//         string answer = Console.ReadLine();
//         if (answer.ToLower() == "yes")
//         {
//             System.Console.WriteLine("Website was quited ! ");
//             break;
//         }
//         else
//         {
//             System.Console.WriteLine("You are continue !");
//             continue;
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("Please enter the number betwen 1 and 4");
//     }
// }
// class student
// {
//     //? Değişkenler
//     private string name;
//     private string surname;
//     private int vize;
//     private int final;
//     private string schoolName;


//     //? Construcator
//     public student(string Name, string SurName, int Vize, int Final, string SchoolName)
//     {
//         name = Name;
//         surname = SurName;
//         vize = Vize;
//         final = Final;
//         schoolName = SchoolName;
//     }

//     //? metod 
//     //* void yerine string veya int kullanırsak hata alırız . 
//     //* return kullanmak için veri tipini belirmemiz gerekir . 
//     //* Void kullanırsak böyle birşeye gerek kalmaz 
//     //* voidde Console.Write kullanırız !
//     public void ShowStudentInformation()
//     {
//         System.Console.WriteLine($"Name : {name}");
//         System.Console.WriteLine($"Surname : {surname}");
//         System.Console.WriteLine($"School name : {schoolName}");
//     }

//     public void findStudentGNA()
//     {
//         System.Console.WriteLine($"Ortalama : {vize * 0.4 + final * 0.6}");
//     }

//     public void GetSchool()
//     {
//         System.Console.WriteLine($"School : {schoolName}");
//     }
// }


//! PROPORTY (ÖZELLİK) 

// müsteri müsteri1 = new müsteri();

// müsteri1.fiyat1 = 85; //* Proporty
// müsteri1.fiyat2 = 85; //* Değişken 
//? eğer get set i açarsak proporty değişken rolunden çıkar ve proporty gibi çalışır

// System.Console.WriteLine("Proporty ->" + müsteri1.fiyat1);
// System.Console.WriteLine("Değişken ->" + müsteri1.fiyat2);


// class müsteri
// {
//     public int fiyat1 { get; set; }
//     public int fiyat2;
// }










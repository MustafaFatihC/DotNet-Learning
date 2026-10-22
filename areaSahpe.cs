using System;

double alan = 0;


while (true)
{

    System.Console.WriteLine("K -> Kare");
    System.Console.WriteLine("C -> Çember");
    System.Console.WriteLine("D -> Diktördgen");
    System.Console.WriteLine("U -> Üçgen");
    System.Console.WriteLine("Escape -> ÇIKIŞ");

    System.Console.WriteLine("");

    System.Console.WriteLine("Please enter your area operation ->");

    var Key = Console.ReadKey(true).Key;



    if (Key == ConsoleKey.K)
    {
        System.Console.WriteLine("Karenin bir kenarını giriniz ->");
        double kenar = Convert.ToDouble(Console.ReadLine());
        alan = kenar * kenar;
        System.Console.WriteLine("....");
        System.Threading.Thread.Sleep(1000);
        System.Console.WriteLine("------------");
        System.Console.WriteLine($"Alan : {alan}");
        System.Console.WriteLine("------------");

    }
    else if (Key == ConsoleKey.C)
    {
        System.Console.WriteLine("Çemberin yarıçapını giriniz ->");
        double r = Convert.ToDouble(Console.ReadLine());
        alan = Math.PI * 2 * r;
        System.Console.WriteLine("....");
        System.Threading.Thread.Sleep(1000);
        System.Console.WriteLine("------------");
        System.Console.WriteLine($"Alan : {alan}");
        System.Console.WriteLine("------------");
    }
    else if (Key == ConsoleKey.D)
    {
        System.Console.WriteLine("Diktörgenin kısa kenarını giriniz ->");
        double kısaKenar = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Diktörgenin uzun kenarını giriniz ->");
        double uzunKenar = Convert.ToDouble(Console.ReadLine());
        alan = kısaKenar * uzunKenar;
        System.Console.WriteLine("....");
        System.Threading.Thread.Sleep(1000);
        System.Console.WriteLine("------------");
        System.Console.WriteLine($"Alan : {alan}");
        System.Console.WriteLine("------------");
    }
    else if (Key == ConsoleKey.U)
    {
        System.Console.WriteLine("Taban uzunluğunu giriniz -> ");
        double tabanAlan = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Yüksekliği giriniz ->");
        double yükseklik = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("....");
        System.Threading.Thread.Sleep(1000);
        alan = yükseklik * tabanAlan / 2;
        System.Console.WriteLine("------------");
        System.Console.WriteLine($"Alan : {alan}");
        System.Console.WriteLine("------------");
    }
    else if (Key == ConsoleKey.Escape)
    {
        System.Console.WriteLine("Çıkış yapıyorsunuz!");
        break;
    }
    else
    {
        System.Console.WriteLine("Lütfen geçerli işlemlerden birini giriniz! ");
    }



}
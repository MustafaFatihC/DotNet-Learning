using System;
using System.Collections.Generic;
using System.Threading;

double budget = 0;

System.Console.WriteLine("Yurt Yemekhanesine Hoşgeldiniz !");
System.Console.WriteLine("Her yemekten sadece bir adet alabilrisiniz !");

while (true)
{

    try
    {
        System.Console.Write("Please enter your budget ->");
        budget = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Rakam veri tipinde işlem yapınız!");
    }
}

System.Console.WriteLine("------Menü------");
System.Console.WriteLine("1: Bulgur Pilavı (bp)");
System.Console.WriteLine("2. Dana Bonfile (db)");
System.Console.WriteLine("3. Tavuk Sote (ts)");
System.Console.WriteLine("4. Tarhana çorbası (tc)");

System.Console.WriteLine("----------------");



double ürün1fiyat = 149.99;
double ürün2fiyat = 449.99;
double ürün3fiyat = 249.99;
double ürün4fiyat = 119.99;

Dictionary<string, double> söylenenler = new Dictionary<string, double>();



while (true)
{


    System.Console.WriteLine("Ne isterdiniz !");
    System.Console.WriteLine("");


    string yemek = "";

    while (true)
    {
        try
        {
            System.Console.Write("Siz: ");
            yemek = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(yemek))
            {
                throw new FormatException();
            }

            break;
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Lütfen bir yemek adı giriniz!");
        }
    }

    if (yemek.ToLower() == "bp")
    {
        if ((budget - ürün1fiyat) >= 0)
        {
            if (söylenenler.ContainsKey("Bulgur Pilavı"))
            {
                Console.WriteLine("Bu yemeği zaten aldınız!");
                continue;
            }
            söylenenler.Add("Bulgur Pilavı", ürün1fiyat);
            budget -= ürün1fiyat;
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("Başka ");
        }
        else
        {
            System.Console.WriteLine("Paranız bu yemeği almaya yetmiyor !");
            continue;
        }
    }

    else if (yemek.ToLower() == "db")
    {
        if (söylenenler.ContainsKey("Dana Bonfile"))
        {
            Console.WriteLine("Bu yemeği zaten aldınız!");
            continue;
        }
        if ((budget - ürün2fiyat) >= 0)
        {

            söylenenler.Add("Dana Bonfile", ürün2fiyat);
            budget -= ürün2fiyat;
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("");
            System.Console.WriteLine("Başka ");
        }
        else
        {
            System.Console.WriteLine("Paranız bu yemeği almaya yetmiyor !");
            continue;
        }
    }

    else if (yemek.ToLower() == "ts")
    {
        if (söylenenler.ContainsKey("Tavuk Sote"))
        {
            Console.WriteLine("Bu yemeği zaten aldınız!");
            continue;
        }
        if ((budget - ürün3fiyat) >= 0)
        {
            söylenenler.Add("Tavuk Sote", ürün3fiyat);
            budget -= ürün3fiyat;
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("");
            System.Console.WriteLine("Başka ");
        }
        else
        {
            System.Console.WriteLine("Paranız bu yemeği almaya yetmiyor !");
            continue;
        }
    }

    else if (yemek.ToLower() == "tc")
    {
        if (söylenenler.ContainsKey("Tarhana Çorbası"))
        {
            Console.WriteLine("Bu yemeği zaten aldınız!");
            continue;
        }
        if ((budget - ürün4fiyat) >= 0)
        {
            söylenenler.Add("Tarhan Çorba", ürün4fiyat);
            budget -= ürün4fiyat;
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("");
            System.Console.WriteLine("Başka ");
        }
        else
        {
            System.Console.WriteLine("Paranız bu yemeği almaya yetmiyor !");
            continue;
        }
    }
    else if (yemek.ToLower() == "bu kadar")
    {
        break;
    }
    else if (yemek.ToLower() == "bütçe")
    {
        System.Console.WriteLine($"Kalan bütçeniz : {budget}");
    }
    else
    {
        System.Console.WriteLine("İstenilen yemek menüde yok");
        System.Console.WriteLine("Başka ");
    }


}


System.Threading.Thread.Sleep(1000);

foreach (var yemek in söylenenler)
{
    System.Console.WriteLine($"{yemek.Key} : {yemek.Value} TL");
}

System.Console.WriteLine($"Kalan para : {budget}");
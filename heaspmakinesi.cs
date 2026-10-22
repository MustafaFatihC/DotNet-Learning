System.Console.WriteLine("Heasp Makinesi uygulamasına Hoşgeldiniz!");


while (true)
{
    System.Console.WriteLine("Topla");
    System.Console.WriteLine("Çıkar");
    System.Console.WriteLine("Çarp");
    System.Console.WriteLine("Bölme");
    System.Console.WriteLine("Çıkış yapmak için -> Quit");
    System.Console.Write("Bir işlem seçiniz -> ");

    string islem = Console.ReadLine();
    islem = islem.ToLower();


    double sonuc = 0;

    if (islem == "topla")
    {

        System.Console.Write("İlk sayıyı giriniz ->");
        double sayı1 = Convert.ToDouble(Console.ReadLine());


        System.Console.Write("İkinci sayıyı giriniz ->");
        double sayı2 = Convert.ToDouble(Console.ReadLine());
        sonuc = sayı1 + sayı2;
    }
    else if (islem == "çıkar")
    {

        System.Console.Write("İlk sayıyı giriniz ->");
        double sayı1 = Convert.ToDouble(Console.ReadLine());


        System.Console.Write("İkinci sayıyı giriniz ->");
        double sayı2 = Convert.ToDouble(Console.ReadLine());
        sonuc = sayı1 - sayı2;
    }
    else if (islem == "çarp")
    {

        System.Console.Write("İlk sayıyı giriniz ->");
        double sayı1 = Convert.ToDouble(Console.ReadLine());


        System.Console.Write("İkinci sayıyı giriniz ->");
        double sayı2 = Convert.ToDouble(Console.ReadLine());
        sonuc = sayı1 * sayı2;
    }
    else if (islem == "bölme")
    {

        System.Console.Write("İlk sayıyı giriniz ->");
        double sayı1 = Convert.ToDouble(Console.ReadLine());


        System.Console.Write("İkinci sayıyı giriniz ->");
        double sayı2 = Convert.ToDouble(Console.ReadLine());
        if (sayı1 == 0)
        {
            System.Console.WriteLine("İlk sayı 0 olamaz !");
        }
        else
        {
            sonuc = sayı1 / sayı2;
        }
    }
    else if (islem == "quit")
    {
        System.Console.WriteLine("çıkış yapıyorsunuz!");
        break;
    }
    else
    {
        System.Console.WriteLine("Lütfen geçerli bir işlem türü seçiniz!");
    }
    System.Console.WriteLine("");
    System.Console.WriteLine($"Sonuç = {sonuc}");
    System.Console.WriteLine("");
}
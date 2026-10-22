List<int> numbers = new List<int>();


while (true)
{
    Console.Write("Lütfen listeye eklemek için bir sayı giriniz (0 çıkışı sağlar !) ->");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 0)
    {
        break;
    }


    numbers.Add(number);


}

numbers.Sort();
numbers.Reverse();

foreach (int number1 in numbers)
{
    Console.WriteLine(number1);
}
Console.WriteLine($"Listenin eleman sayısı -> {numbers.Count}");


int max = numbers[0];

foreach (int number2 in numbers)
{
    if (max < number2)
    {
        max = number2;
    }
}

Console.WriteLine($"Oluşturmuş olduğun listedeki en büyük sayı {max}'dır !");





int min = numbers[0];

foreach (int number2 in numbers)
{
    if (min > number2)
    {
        min = number2;
    }
}

Console.WriteLine($"Oluşturmuş olduğun listedeki en küçük sayı {min}'dır !");



int toplam = 0;

foreach (int sayı in numbers)
{
    toplam += sayı;
}
Console.WriteLine($"Oluşturmuş olduğunuz listedeki elemenarın toplamı {toplam}'dır !");
Console.WriteLine($"Oluşturmuş olduğunuz listedeki elemenarın ortalaması {(double)toplam / numbers.Count}'dır !");


Console.Write("Aramak istediğiniz sayısyı seçiniz ->");
int istenilenCount = Convert.ToInt32(Console.ReadLine());
int count = 0;

foreach (int kacdefa in numbers)
{
    if (kacdefa == istenilenCount)
    {
        count++;
    }
}

Console.WriteLine($"Seçtiğiniz {istenilenCount} sayısı listede {count} kez geçmektedir ! ");
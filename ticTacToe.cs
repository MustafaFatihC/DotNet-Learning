List<int> numbers = new List<int>();

int sayılar = 1;
bool isWin = true;

while (isWin)
{
    for (int satır = 1; satır <= 3; satır++)
    {

        for (int sütun = 1; sütun <= 3; sütun++)
        {
            System.Console.Write(" " + sayılar + " |");
            numbers.Add(sayılar);
            sayılar++;
        }
        System.Console.WriteLine();
        System.Console.WriteLine("---------------");
    }


    System.Console.WriteLine("Please enter a number which one is you want to change with X :");
    int changeNumber = Convert.ToInt32(Console.ReadLine());
    foreach (var number in numbers)
    {
        if (number == changeNumber)
        {
            numbers[number] = changeNumber;
        }
        else
        {
            continue;
        }
    }
    if (changeNumber == 0)
    {
        break;
    }

}

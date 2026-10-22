List<int> numbers = new List<int>();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.Write("Please enter a number to search in list -> ");
int number = Convert.ToInt32(Console.ReadLine());

if (numbers.Contains(number))
{
    int index = numbers.IndexOf(number);

    numbers.Remove(number);

    Console.WriteLine($"Index of searching number is -> {index}");
    Console.WriteLine($"Removed number is {number}");
}
else
{
    Console.WriteLine($"{number} is undefined!");
}

foreach (int number2 in numbers)
{
    Console.WriteLine(number2);
}
int secretNumber = 7;
int guess = 0;
while (guess != secretNumber)
{
    Console.Write("Please enter a number for guess the secret number ->");
    guess = Convert.ToInt16(Console.ReadLine());
    if (guess == secretNumber)
    {
        Console.WriteLine($"Your guess is {guess} ");
        Console.WriteLine("Your guess is true");
        break;

    }
    else if (guess == 0)
    {
        Console.WriteLine($"Your close the program , because you write {guess}");
        break;
    }
    else
    {
        Console.WriteLine($"Your guess is {guess} ");
        Console.WriteLine("Your guess is wrong!");

    }
}
bool isEven(int number)
{
    return number % 2 == 0;
}

bool isPositive(int number2)
{
    if (number2 > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int GetAge(int birthYear)
{
    if (birthYear <= 2008)
    {
        return 2026 - birthYear;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine(GetAge(2008));

Console.WriteLine(isEven(10));

Console.WriteLine(isEven(3));

Console.WriteLine(isPositive(10));

Console.WriteLine(isPositive(0));

Console.WriteLine(isPositive(-1));


int square(int x)
{
    return x * x;
}

bool isPositive(int x)
{
    if (x > 0)
    {
        return true;
    }
    else
    {
        return false;

    }
}
bool tekCift(int x)
{
    if (x % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}


Console.Write("Please enter a number ->");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Which operation do you prefer (square/isPositive/tekCift) ->");
string operation = Console.ReadLine();

switch (operation)
{
    case "square":
        Console.WriteLine(square(number1));
        break;
    case "isPositive":
        Console.WriteLine(isPositive(number1));
        break;
    case "tekCift":
        Console.WriteLine(tekCift(number1));
        break;
    default:
        Console.WriteLine("Your operation choose is non-defined !");
        break;
}



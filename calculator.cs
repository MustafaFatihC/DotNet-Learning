int calculator()
{
    Console.Write("Please enter a math operation (Add,Substract,Divide,Multiply)->");
    string operation = Console.ReadLine();

    if (operation == "Add")
    {
        Console.Write("Please enter a number for Add operation ->");
        int number1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Please enter a number for Add operation ->");
        int number2 = Convert.ToInt16(Console.ReadLine());
        return number1 + number2;
    }
    else if (operation == "Substract")
    {
        Console.Write("Please enter a number for Substract operation ->");
        int number1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Please enter a number for Substract operation ->");
        int number2 = Convert.ToInt16(Console.ReadLine());
        return number1 - number2;
    }
    else if (operation == "Divide")
    {
        Console.Write("Please enter a number for Divide operation ->");
        int number1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Please enter a number for Divide operation ->");
        int number2 = Convert.ToInt16(Console.ReadLine());
        return number1 / number2;
    }
    else if (operation == "Multiply")
    {
        Console.Write("Please enter a number for Multiply operation ->");
        int number1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Please enter a number for Multiply operation ->");
        int number2 = Convert.ToInt16(Console.ReadLine());
        return number1 * number2;
    }
    return 0;
}
Console.WriteLine(calculator());


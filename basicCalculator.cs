
System.Console.Write("Please enter the first number ->");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Please enter the second number ->");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = 0;


if (num2 == 0)
{
    System.Console.WriteLine("Second number cannot be 0 !");
}
else
{

    while (true)
    {
        System.Console.WriteLine("Operation options : ");
        System.Console.WriteLine("Operation options:");
        System.Console.WriteLine("1. Toplama (+)");
        System.Console.WriteLine("2. Çıkartma (-)");
        System.Console.WriteLine("3. Çarpma (*)");
        System.Console.WriteLine("4. Bölme (/)");

        System.Console.Write("Please enter the operation ->");
        string operation = Console.ReadLine();

        if (operation == "+")
        {
            result = num1 + num2;
            break;
        }
        else if (operation == "-")
        {
            result = num1 - num2;
            break;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
            break;
        }
        else if (operation == "/")
        {
            result = num1 / num2;
            break;
        }
        else
        {
            System.Console.WriteLine("Please enter correct operation !");
        }

    }
    System.Console.WriteLine($"Result : {result}");
}



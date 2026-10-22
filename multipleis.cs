Console.Write("Please enter a number->");
int number = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"Multipleis table of your number");
for (int i = 1; i <= 10; i++)
{

    Console.WriteLine($" {number} x {i}= {number * i}");
}
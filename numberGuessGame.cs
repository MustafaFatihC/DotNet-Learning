using System;

Random random = new Random();

int RandomNumber;

RandomNumber = random.Next(1, 11);

while (true)
{
    try
    {


        System.Console.WriteLine(" ");
        System.Console.WriteLine(" ---------------- ");
        System.Console.Write("Please enter a number betwen 1-10 -> ");
        int guessNum = Convert.ToInt32(Console.ReadLine());

        if (0 < guessNum && guessNum < 11)
        {



            if (guessNum == RandomNumber)
            {
                System.Console.WriteLine("---------------");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Your number equals the PC's number !");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Your guess : {guessNum}");
                System.Console.WriteLine($"Random number : {RandomNumber}");
                break;

            }
            else
            {
                System.Console.WriteLine("----------------");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Your number NOT equals the PC's number !");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Your guess : {guessNum}");
                System.Console.WriteLine(" ");

                if (guessNum < RandomNumber)
                {
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Try a higher number!");
                    System.Console.WriteLine("");
                }
                else
                {
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Try a lower number!");
                    System.Console.WriteLine("");
                }

            }

        }
        else
        {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Please enter number betwen 1-10 !");
            System.Console.WriteLine("");
        }
    }
    catch (FormatException)
    {
        System.Console.WriteLine("");
        System.Console.WriteLine("Please enter correct type!");
        System.Console.WriteLine("");
    }
}
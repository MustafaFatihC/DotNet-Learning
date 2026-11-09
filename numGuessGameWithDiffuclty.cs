Random random = new Random();

int[] wins = new int[3];
int[] losses = new int[3];
int[] bestScores = new int[3];

bool isNumberTrue = true;
int attemps = 0;
int secretNumber = 0;

while (true)
{
    isNumberTrue = true;


    System.Console.WriteLine("1. Easy   (1-50,  10 attempts)");
    System.Console.WriteLine("2. Medium (1-100, 7 attempts)");
    System.Console.WriteLine("3. Hard   (1-200, 6 attempts)");
    System.Console.WriteLine("0 for leave !");
    System.Console.Write("Choose level:");
    int difficulty = Convert.ToInt32(Console.ReadLine());

    if (difficulty == 0)
    {

        System.Console.WriteLine("Quiting the game!");
        Thread.Sleep(1000);
        break;
    }

    switch (difficulty)
    {
        case 1:
            secretNumber = random.Next(1, 51);
            System.Console.WriteLine("I picked a number between 1 and 50 . You have 10 attemps");
            attemps = 10;
            while (isNumberTrue && attemps >= 1)
            {

                System.Console.Write("Please do a guess:");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > 50 || guess < 1)
                {
                    System.Console.WriteLine("Please enter valid number!");
                }
                else
                {
                    if (guess < secretNumber)
                    {
                        System.Console.WriteLine("Too low ! Go higher.");
                        attemps--;
                        System.Console.WriteLine($"You have {attemps} attemps left.");
                    }
                    else if (guess == secretNumber)
                    {
                        System.Console.WriteLine("Correct Guess!!");

                        isNumberTrue = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Too high! Go lower.");
                        attemps--;
                        System.Console.WriteLine($"You have {attemps} attemps left.");
                    }

                }

            }
            if (attemps == 0)
            {
                System.Console.WriteLine($"You lost! The number was {secretNumber}.");
            }
            if (isNumberTrue == false)
            {
                System.Console.WriteLine("asjdklajdlşasdas");
                wins.Append(1);
            }
            else
            {
                System.Console.WriteLine("asjdklajdlşasdas");
                losses.Append(2);
            }
            break;
        case 2:
            secretNumber = random.Next(1, 101);
            System.Console.WriteLine("I picked a number between 1 and 100 . You have 7 attemps");
            attemps = 7;
            while (isNumberTrue && attemps >= 1)
            {

                System.Console.Write("Please do a guess:");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > 100 || guess < 1)
                {
                    System.Console.WriteLine("Please enter valid number!");
                }
                else
                {
                    if (guess < secretNumber)
                    {
                        System.Console.WriteLine("Too low ! Go higher.");
                        attemps--;
                        System.Console.WriteLine($"You have {attemps} attemps left.");
                    }
                    else if (guess == secretNumber)
                    {
                        System.Console.WriteLine("Correct Guess!!");
                        isNumberTrue = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Too high! Go lower.");
                        attemps--;
                        System.Console.WriteLine($"You have {attemps} attemps left.");
                    }

                }
            }
            if (attemps == 0)
            {
                System.Console.WriteLine($"You lost! The number was {secretNumber}.");
            }

            break;
        case 3:
            secretNumber = random.Next(1, 201);
            System.Console.WriteLine("I picked a number between 1 and 200 . You have 6 attemps");
            attemps = 6;
            while (isNumberTrue && attemps >= 1)
            {

                System.Console.Write("Please do a guess:");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > 200 || guess < 1)
                {
                    System.Console.WriteLine("Please enter valid number!");
                }
                else
                {
                    if (guess < secretNumber)
                    {
                        System.Console.WriteLine("Too low ! Go higher.");
                        attemps--;
                        System.Console.WriteLine($"You have {attemps} attemps left.");
                    }
                    else if (guess == secretNumber)
                    {
                        System.Console.WriteLine("Correct Guess!!");
                        isNumberTrue = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Too high! Go lower.");
                        attemps--;
                        System.Console.WriteLine($"You have {attemps} attemps left.");
                    }

                }
            }
            if (attemps == 0)
            {
                System.Console.WriteLine($"You lost! The number was {secretNumber}.");
            }
            break;
        default:
            System.Console.WriteLine("Please enter valid operation!!!");
            break;
    }

}
for (int i = 0; i < 3; i++)
{
    if (wins[i] == 1)
    {
        System.Console.WriteLine($"{i}) Win!");
    }
    else
    {
        continue;
    }

}

for (int i = 0; i < 3; i++)
{
    if (losses[i] == 2)
    {
        System.Console.WriteLine($"{i}) Lose!");
    }
    else
    {
        continue;
    }
}
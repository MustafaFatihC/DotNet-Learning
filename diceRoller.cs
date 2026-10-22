using System;

int playerRandomNum;
int enemyRandomNum;

int playerAllPoint = 0;
int enemyAllPoint = 0;


Random random = new Random();

for (int i = 1; i < 4; i++)
{
    System.Console.WriteLine(" ");
    System.Console.WriteLine("Press any key to roll the dice !");

    Console.ReadKey();

    playerRandomNum = random.Next(1, 7);
    System.Console.WriteLine($"You rolled a {playerRandomNum}");
    System.Console.WriteLine("");
    System.Console.WriteLine("...");
    System.Console.WriteLine(" ");
    System.Threading.Thread.Sleep(1000);

    enemyRandomNum = random.Next(1, 7);
    System.Console.WriteLine($"Enemy rolled a {enemyRandomNum}");

    playerAllPoint += playerRandomNum;
    enemyAllPoint += enemyRandomNum;
}
System.Console.WriteLine(" ");
System.Console.WriteLine("---------------");
System.Console.WriteLine(" ");
if (playerAllPoint > enemyAllPoint)
{
    System.Console.WriteLine("Player win !");
    System.Console.WriteLine($"Player's point : {playerAllPoint}");
    System.Console.WriteLine($"Enemy's point : {enemyAllPoint}");
}
else if (playerAllPoint == enemyAllPoint)
{
    System.Console.WriteLine("There is no winner !");
    System.Console.WriteLine($"Player's point : {playerAllPoint}");
    System.Console.WriteLine($"Enemy's point : {enemyAllPoint}");
}
else
{
    System.Console.WriteLine("Enemy win !");
    System.Console.WriteLine($"Player's point : {playerAllPoint}");
    System.Console.WriteLine($"Enemy's point : {enemyAllPoint}");
}
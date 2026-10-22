using System;

Random random = new Random();


int playerHP = 40;
int EnemyHP = 20;

while (playerHP > 0 && EnemyHP > 0)
{


    System.Console.WriteLine("A -> Attack");
    System.Console.WriteLine("H -> Heal");
    System.Console.WriteLine(" ");
    System.Console.Write("Please enter Attack or heal ->");
    string answer = Console.ReadLine();
    System.Console.WriteLine("------------");

    if (answer.ToLower() == "a")
    {

        System.Console.WriteLine("Player attacked enemy!");
        System.Threading.Thread.Sleep(1000);

        EnemyHP -= random.Next(1, 11);

        System.Threading.Thread.Sleep(1000);

        playerHP -= random.Next(1, 6);

        System.Console.WriteLine($"Player HP : {playerHP}");
        System.Console.WriteLine($"Enemy HP : {EnemyHP}");
        System.Console.WriteLine("------------");

    }
    else if (answer.ToLower() == "h")
    {


        System.Threading.Thread.Sleep(1000);

        System.Console.WriteLine("You healed your self !");

        System.Threading.Thread.Sleep(1000);

        playerHP += random.Next(1, 4);

        playerHP -= random.Next(1, 6);

        System.Console.WriteLine($"Player HP : {playerHP}");
        System.Console.WriteLine($"Enemy HP : {EnemyHP}");
        System.Console.WriteLine("------------");
    }
    else
    {
        System.Console.WriteLine("Please enter Valid string !");
        System.Console.WriteLine("------------");
    }
}


if (EnemyHP <= 0)
{
    System.Console.WriteLine("Player win !");
}
else
{
    System.Console.WriteLine("Enemy win !");
}

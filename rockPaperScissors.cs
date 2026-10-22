using System;


System.Console.WriteLine("Welcome to Rock Paper Scissors");

Random random = new Random();

int playerPoint = 0;

int pcPoint = 0;

//! r rock 1
//! p paper 2 
//! s scissor 3

int gameNumber = 1;
while (true)
{




    if (gameNumber <= 3)
    {
        try
        {
            System.Console.Write("Please enter '1' for rock , '2' for paper , '3' for scissors -> ");
            int answer = Convert.ToInt32(Console.ReadLine());

            int pcAnswer = random.Next(1, 4);

            System.Console.WriteLine("-------------");
            System.Console.WriteLine($"Game no ->{gameNumber}");
            System.Console.WriteLine("");


            if (answer == pcAnswer)
            {
                System.Console.WriteLine("Tie!");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Pc's answer -> {pcAnswer}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Player's point : {playerPoint}");
                System.Console.WriteLine($"PC' point : {pcPoint}");
                gameNumber++;
            }
            else if (answer == 1 && pcAnswer == 2)
            {
                System.Console.WriteLine("PC won!");

                pcPoint += 1;
                System.Console.WriteLine($"Pc's answer -> {pcAnswer}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Player's point : {playerPoint}");
                System.Console.WriteLine($"PC' point : {pcPoint}");
                gameNumber++;
            }
            else if (answer == 1 && pcAnswer == 3)
            {
                System.Console.WriteLine("Player won!");
                System.Console.WriteLine($"Pc's answer -> {pcAnswer}");
                playerPoint += 1;
                System.Console.WriteLine("");
                System.Console.WriteLine($"Player's point : {playerPoint}");
                System.Console.WriteLine($"PC' point : {pcPoint}");
                gameNumber++;
            }
            else if (answer == 2 && pcAnswer == 1)
            {
                System.Console.WriteLine("Player won!");

                playerPoint += 1;
                System.Console.WriteLine($"Pc's answer -> {pcAnswer}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Player's point : {playerPoint}");
                System.Console.WriteLine($"PC' point : {pcPoint}");
                gameNumber++;

            }
            else if (answer == 2 && pcAnswer == 3)
            {
                System.Console.WriteLine("PC won!");
                System.Console.WriteLine($"Pc's answer -> {pcAnswer}");
                pcPoint += 1;
                System.Console.WriteLine("");
                System.Console.WriteLine($"Player's point : {playerPoint}");
                System.Console.WriteLine($"PC' point : {pcPoint}");
                gameNumber++;
            }
            else if (answer == 3 && pcAnswer == 1)
            {
                System.Console.WriteLine("PC won!");
                System.Console.WriteLine($"Pc's answer -> {pcAnswer}");

                pcPoint += 1;
                System.Console.WriteLine("");
                System.Console.WriteLine($"Player's point : {playerPoint}");
                System.Console.WriteLine($"PC' point : {pcPoint}");
                gameNumber++;
            }
            else if (answer == 3 && pcAnswer == 2)
            {
                System.Console.WriteLine("Player won!");
                System.Console.WriteLine($"Pc's answer -> {pcAnswer}");
                playerPoint += 1;
                System.Console.WriteLine("");
                System.Console.WriteLine($"Player's point : {playerPoint}");
                System.Console.WriteLine($"PC' point : {pcPoint}");
                gameNumber++;
            }
            else if (answer < 1 || answer > 3)
            {
                System.Console.WriteLine("Please enter valid number!");
                continue;
            }

        }
        catch (FormatException)
        {
            System.Console.WriteLine("Please enter valid type!");
        }
    }
    else
    {
        if (playerPoint > pcPoint)
        {
            System.Console.WriteLine("Player won!");
        }
        else
        {
            System.Console.WriteLine("PC won!");
        }
        break;
    }

}
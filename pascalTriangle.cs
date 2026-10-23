// Pascal üçgeni oluşturmak için bir C# programı




using System;

System.Console.Write("Lütfen row sayısını giriniz -> ");

int row = int.Parse(Console.ReadLine());

for (int i = 0; i <= row; i++)
{
    for (int j = 0; j < row - i + 1; j++)
    {
        System.Console.Write(" ");
    }

    int number = 1;
    for (int k = 0; k <= i; k++)
    {
        System.Console.Write(number + " ");
        number = number * (i - k) / (k + 1);
    }
    System.Console.WriteLine();
}



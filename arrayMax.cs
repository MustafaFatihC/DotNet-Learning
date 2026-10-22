// Console.Write("How much number will you enter ->");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array1 = new int[number];

// int max = array1[0];
// int maxIndex = 0;

// for (int i = 0; i < array1.Length; i++)
// {
//     Console.Write($"{i + 1}. sayıyı gir ->");
//     array1[i] = Convert.ToInt32(Console.ReadLine());
// }



// for (int i = 0; i < array1.Length; i++)
// {
//     if (max < array1[i])
//     {
//         max = array1[i];
//         maxIndex = i;
//     }
// }

// Console.WriteLine(max);
// Console.WriteLine($"Index: {maxIndex}");



//! min

Console.Write("How much number will you enter ->");
int number = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[number]; //10 11 12


for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"{i + 1}. sayıyı gir ->");
    array1[i] = Convert.ToInt32(Console.ReadLine());
}

int min = array1[0]; // 10
int minİndex = 0;


for (int i = 0; i < array1.Length; i++)
{
    if (min > array1[i])
    {
        min = array1[i];
        minİndex = i;
    }
}

Console.WriteLine(min);
Console.WriteLine($"Index: {minİndex}");
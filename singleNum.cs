// Bir array oluşturulacak ve o dizide yalnızca bir kez bulunan sayıyı dödürecek bir program yazılacak. 


// array leetcode'dan alınacak ve yalnızca bir kez bulunan sayıyı döndürecek bir program yazılacak.


//eklenecek eleman sayısı için kullanıcıdan girdi.

Console.Write("Lütfen array'e eklenecek eleman sayısını giriniz -> ");
int numCount = Convert.ToInt32(Console.ReadLine());


int[] array = new int[numCount]; // array boyutu kullanıcıdan alınacak.

// array'e eleman eklemek için döngü !

for (int i = 0; i < numCount; i++)
{
    Console.Write($"Lütfen {i + 1}. elemanı giriniz -> ");
    int num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
}

// Şimdi array'de yalnızca bir kez bulunan sayıyı bulmak için bir döngü yazılacak. 

foreach (int num in array)
{
    int count = 0;
    foreach (int n in array)
    {
        if (n == num)
        {
            count++;
        }
    }
    if (count == 1)
    {
        Console.WriteLine($"Yalnızca bir kez bulunan sayı -> {num}");
        break;
    }
}



int[] dizi = [10, 20, 30, 40, 50];
Console.Write("Please enter a number for search in on array ->");
int search = Convert.ToInt32(Console.ReadLine());
int index = 0;

for (int i = 0; i < dizi.Length; i++)
{
    if (dizi[i] == search)
    {
        index = i;
        Console.WriteLine($"{search} is in the array ! and its index is {index} ");
        break;
    }


}

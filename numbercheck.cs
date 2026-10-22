Console.Write("Bir sayı giriniz -> ");
int sayı = Convert.ToInt32(Console.ReadLine());
if (sayı > 0)
{
    Console.WriteLine("Pozitif Sayı");
}
else if (sayı == 0)
{
    Console.WriteLine("Sıfır");
}
else
{
    Console.WriteLine("Negatif Sayı");
}
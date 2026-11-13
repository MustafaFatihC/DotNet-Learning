string word = "türkiye";
List<string> usedHarfler = new List<string>();


char[] display = new char[word.Length];

for (int i = 0; i < word.Length; i++)
{
    display[i] = '_';
}
System.Console.Write("Word:");
System.Console.Write(display);
System.Console.WriteLine();


bool isFound = false;


System.Console.Write("Harf giriniz: ");
string harf = Console.ReadLine() ?? "";

foreach (var ha in word)
{
    if (harf.ToLower() == ha.ToString())
    {
        isFound = true;

    }

}
if (isFound)
{
    System.Console.WriteLine("Harf kelimenin içinde var!");

    if (!usedHarfler.Contains(harf))
    {
        usedHarfler.Add(harf);
    }

}
else
{
    System.Console.WriteLine("Harf kelimenin içinde yok!");
    usedHarfler.Add(harf);
}

foreach (var used in usedHarfler) //* kullanılan kelimeleri yazdırır
{
    System.Console.Write(used + "/");
}


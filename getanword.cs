Console.Write("Please a word -> ");
string word = Console.ReadLine();
Console.WriteLine($"Your word's length is  {word.Length} characters ");
Console.WriteLine($"Your word's upper version is {word.ToUpper()}");
Console.WriteLine($"Your word's lower version is {word.ToLower()}");
Console.WriteLine($"Does your word's have the letter a {word.Contains("a")}");
//! array

// int[] numbers = { 11, 12, 13, 9, 10 };
// int index = 0;
// foreach (var number in numbers)
// {
//     System.Console.WriteLine($"İndex :{index} , Number : {number}");
//     index++;
// }


// Array.Sort(numbers);


// foreach (var number in numbers)
// {
//     System.Console.WriteLine($"İndex :{index} , Number : {number}");
//     index++;
// }




//! list

// List<string> names = new List<string>();
// System.Console.Write("Please enter your name:");
// string name = Console.ReadLine();
// names.Add(name);

// foreach (var ad in names)
// {
//     System.Console.WriteLine(ad);
// }


//! Dictionary 

Dictionary<string, int> products = new Dictionary<string, int>();

products.Add("Keyvoard", 10);
products.Add("Mouse", 5);

foreach (var product in products)
{
    System.Console.WriteLine($"Product name : {product.Key} , how many have there : {product.Value}");
}
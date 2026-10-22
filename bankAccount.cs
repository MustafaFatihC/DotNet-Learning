BankAccount account1 = new BankAccount();

BankAccount account2 = new BankAccount("Ahmet");

BankAccount account3 = new BankAccount("Mehmet", 5000);
Console.WriteLine(" ");
Console.WriteLine("----------------------");
Console.WriteLine(" ");
account1.Showİnfo();
Console.WriteLine(" ");
Console.WriteLine("----------------------");
Console.WriteLine(" ");
account2.Showİnfo();
Console.WriteLine(" ");
Console.WriteLine("----------------------");
Console.WriteLine(" ");
account3.Showİnfo();
Console.WriteLine(" ");
Console.WriteLine("----------------------");




class BankAccount
{
    public string Name;

    public int Balance;

    public BankAccount()
    {
        Name = "Unknown";
        Balance = 0;
    }
    public BankAccount(string name)
    {
        Name = name;
        Balance = 0;
    }
    public BankAccount(string name, int balance)
    {
        Name = name;
        Balance = balance;
    }


    public void Showİnfo()
    {
        Console.WriteLine($"Name -> {Name}");
        Console.WriteLine($"Balance -> {Balance}");
    }
}
BankAccount account1 = new BankAccount();

BankAccount account2 = new BankAccount("Ahmet");

BankAccount account3 = new BankAccount("Mehmet", 5000);

account1.ShowInfo();

account2.ShowInfo();

account3.ShowInfo();





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


    public void ShowInfo()
    {
        System.Console.WriteLine("");
        System.Console.WriteLine("---------------");
        Console.WriteLine($"Name -> {Name}");
        Console.WriteLine($"Balance -> {Balance}");
        System.Console.WriteLine("---------------");
    }
}
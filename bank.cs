
BankAccount account = new BankAccount(1000);

Console.Write("Please enter your operation (Deposit-Withrad-ShowBalance) -> ");
string operation = Console.ReadLine();

if (operation == "Deposit" || operation == "Withrad")
{
    Console.Write("Please enter the amount -> ");
    int money = Convert.ToInt32(Console.ReadLine());

    if (operation == "DeSposit")
    {
        account.Deposit(money);
    }
    else
    {
        account.Withrad(money);
    }
}

account.AccountInfo(operation);


class BankAccount
{
    private double Balance;

    public BankAccount(double balance)
    {
        Balance = balance;
    }

    public void Deposit(int money)
    {
        Balance += money;
    }

    public void Withrad(int money)
    {
        Balance -= money;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Your balance -> {Balance}");
    }

    public void AccountInfo(string operation)
    {
        if (operation == "Deposit" || operation == "Withrad")
        {
            Console.WriteLine($"Your left money -> {Balance}");
        }
        else
        {
            ShowBalance();
        }
    }
}


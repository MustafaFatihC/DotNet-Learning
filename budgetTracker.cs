
System.Console.WriteLine("============== BUDGET TRACKER ==============");

Dictionary<string, int> Income = new Dictionary<string, int>();
Dictionary<string, int> Expense = new Dictionary<string, int>();

while (true)
{
    System.Console.WriteLine("\n1. Add Income");
    System.Console.WriteLine("2. Add Expense");
    System.Console.WriteLine("3. View Transactions");
    System.Console.WriteLine("4. View Balance");
    System.Console.WriteLine("5. View Statistics");
    System.Console.WriteLine("E. Exit");

    System.Console.Write("\nChoose an option: ");
    string? opinion = Console.ReadLine();

    if (opinion?.ToLower() == "e")
    {
        System.Console.WriteLine("Exit!");
        break;
    }

    switch (opinion)
    {
        case "1":
            {
                System.Console.Write("Name: ");
                string? name = Console.ReadLine();

                System.Console.Write("Income Price: ");

                if (string.IsNullOrWhiteSpace(name) ||
                    !int.TryParse(Console.ReadLine(), out int price) ||
                    price <= 0)
                {
                    System.Console.WriteLine("Invalid name or price!");
                    break;
                }

                if (Income.ContainsKey(name))
                {
                    System.Console.WriteLine("This income name already exists!");
                    break;
                }

                Income.Add(name, price);
                System.Console.WriteLine("Income added successfully!");
                break;
            }

        case "2":
            {
                System.Console.Write("Name: ");
                string? name = Console.ReadLine();

                System.Console.Write("Expense Price: ");

                if (string.IsNullOrWhiteSpace(name) ||
                    !int.TryParse(Console.ReadLine(), out int price) ||
                    price <= 0)
                {
                    System.Console.WriteLine("Invalid name or price!");
                    break;
                }

                if (Expense.ContainsKey(name))
                {
                    System.Console.WriteLine("This expense name already exists!");
                    break;
                }

                Expense.Add(name, price);
                System.Console.WriteLine("Expense added successfully!");
                break;
            }

        case "3":
            {
                System.Console.WriteLine("\n========== ALL TRANSACTIONS ==========");

                System.Console.WriteLine("\nINCOMES:");

                foreach (var item in Income)
                {
                    System.Console.WriteLine($"{item.Key}: +{item.Value}");
                }

                System.Console.WriteLine("\nEXPENSES:");

                foreach (var item in Expense)
                {
                    System.Console.WriteLine($"{item.Key}: -{item.Value}");
                }

                break;
            }

        case "4":
        case "5":
            {
                int totalIncome = 0;
                int totalExpense = 0;

                foreach (var item in Income)
                {
                    totalIncome += item.Value;
                }

                foreach (var item in Expense)
                {
                    totalExpense += item.Value;
                }

                int balance = totalIncome - totalExpense;

                if (opinion == "4")
                {
                    System.Console.WriteLine("\n========== CURRENT BALANCE ==========");
                    System.Console.WriteLine($"Total Income: {totalIncome}");
                    System.Console.WriteLine($"Total Expense: {totalExpense}");
                    System.Console.WriteLine($"Current Balance: {balance}");
                }
                else
                {
                    System.Console.WriteLine("\n========== BUDGET STATISTICS ==========");
                    System.Console.WriteLine($"Total Income: {totalIncome}");
                    System.Console.WriteLine($"Total Expense: {totalExpense}");
                    System.Console.WriteLine($"Net Savings: {balance}");
                    System.Console.WriteLine($"Income Transactions: {Income.Count}");
                    System.Console.WriteLine($"Expense Transactions: {Expense.Count}");
                }

                break;
            }

        default:
            System.Console.WriteLine("Invalid option! Please choose 1-5 or E.");
            break;
    }
}

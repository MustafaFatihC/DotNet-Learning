string accountHolder = "Mustafa";
string password = "1234";
decimal balance = 5000;
int chance = 3;
bool isRunning = true;


System.Console.WriteLine($"You have 3 chance to enter correct pasword!");

while (chance >= 1 && isRunning)
{



    System.Console.Write("Please enter Pasword :");
    string inPasword = Console.ReadLine();

    if (inPasword == password)
    {
        System.Console.WriteLine("===== BANK ATM =====");

        System.Console.WriteLine("1.Check Balance");
        System.Console.WriteLine("2. Deposit Money");
        System.Console.WriteLine("3. Withdraw Money");
        System.Console.WriteLine("4. Change Password");
        System.Console.WriteLine("5. Transaction History");
        System.Console.WriteLine("E. Exit");

        System.Console.Write("What option do you prefer:");
        string choosenOption = Console.ReadLine();

        switch (choosenOption)
        {
            case "1":
                System.Console.WriteLine($"You have {balance}$ money");
                break;
            case "2":

                Console.Write("How much money do you deposit: ");
                int depositMoney;

                if (int.TryParse(Console.ReadLine(), out depositMoney))
                {
                    balance += depositMoney;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                System.Console.WriteLine($"You have {balance} money now...");
                break;

            case "3":

                Console.Write("How much money do you withdraw: ");
                int withdrawMoney;

                if (int.TryParse(Console.ReadLine(), out withdrawMoney))
                {
                    balance += withdrawMoney;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                System.Console.WriteLine($"You have {balance} money now...");
                break;
            case "4":
                System.Console.Write("Please enter new pasword :");
                string newPasword = Console.ReadLine();
                if (newPasword == password)
                {
                    System.Console.WriteLine("You must enter different pasword!");
                }
                else
                {
                    password = newPasword;
                    System.Console.WriteLine($"Your pasword : {newPasword}");

                }
                break;
            case "E":
                System.Console.WriteLine("You are quiting...");
                Thread.Sleep(1000);
                isRunning = false;
                break;

            default:
                System.Console.WriteLine("Please enter valid operation!");
                break;
        }

    }
    else
    {


        System.Console.WriteLine("Pasword isn't true !");
        chance--;
        System.Console.WriteLine($"You have {chance} chance left!");
    }
}
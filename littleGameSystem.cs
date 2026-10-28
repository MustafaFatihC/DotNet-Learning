
int playerHP = 100;
int playerAttackPower = 20;
int gold = 20;
int potion = 3;
string playerWeapon = "Basic Sword";

Random random = new Random();

while (true)
{
    Console.WriteLine("\n1. View Player Stats");
    Console.WriteLine("2. Fight Monster");
    Console.WriteLine("3. Visit Shop");
    Console.WriteLine("4. View Inventory");
    Console.WriteLine("E. Exit");
    Console.Write("Choose an option: ");

    string answer1 = (Console.ReadLine() ?? "").ToLower();

    if (answer1 == "e")
    {
        Console.Write("Are you sure you want to leave? (y/n): ");
        string sureToQuit = (Console.ReadLine() ?? "").ToLower();

        if (sureToQuit == "y")
        {
            Console.WriteLine("You are leaving...");
            break;
        }

        Console.WriteLine("Returning to the game...");
        continue;
    }

    switch (answer1)
    {
        case "1":
            Console.WriteLine(
                $"\nPlayer HP: {playerHP}" +
                $"\nAttack Power: {playerAttackPower}" +
                $"\nGold: {gold}" +
                $"\nPotion Stock: {potion}");
            break;

        case "2":
            {
                if (playerHP <= 0)
                {
                    Console.WriteLine("You are dead! You cannot fight.");
                    break;
                }

                int monsterHP = random.Next(50, 201);
                int monsterAttackPower = random.Next(5, 21);

                Console.WriteLine("\nA monster appeared!");

                while (playerHP > 0 && monsterHP > 0)
                {
                    Console.WriteLine("\n========================");
                    Console.WriteLine($"Player HP: {playerHP}");
                    Console.WriteLine($"Monster HP: {monsterHP}");
                    Console.WriteLine("1. Attack Monster");
                    Console.WriteLine("2. Use Potion");
                    Console.Write("Choose an option: ");

                    string answer2 = Console.ReadLine() ?? "";

                    switch (answer2)
                    {
                        case "1":
                            monsterHP -= playerAttackPower;

                            if (monsterHP > 0)
                            {
                                playerHP -= monsterAttackPower;
                            }

                            break;

                        case "2":
                            if (potion > 0)
                            {
                                if (playerHP >= 100)
                                {
                                    Console.WriteLine("Your HP is already full!");
                                }
                                else
                                {
                                    int healPower = random.Next(5, 10);
                                    playerHP = Math.Min(playerHP + healPower, 100);
                                    potion--;

                                    Console.WriteLine($"You recovered HP. Current HP: {playerHP}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You don't have any potions!");
                            }

                            break;

                        default:
                            Console.WriteLine("Invalid battle option!");
                            break;
                    }

                    Console.WriteLine($"Player HP: {playerHP}");
                    Console.WriteLine($"Monster HP: {monsterHP}");

                    if (playerHP <= 0 && monsterHP <= 0)
                    {
                        Console.WriteLine("Draw!");
                        break;
                    }
                    else if (monsterHP <= 0)
                    {
                        Console.WriteLine("Player won!");

                        int randomGold = random.Next(1, 6);
                        gold += randomGold;

                        Console.WriteLine($"You earned {randomGold} gold!");
                        break;
                    }
                    else if (playerHP <= 0)
                    {
                        Console.WriteLine("Player lost!");
                        break;
                    }
                }

                break;
            }

        case "3":
            {
                if (playerHP <= 0)
                {
                    Console.WriteLine("You are dead! You cannot use the shop.");
                    break;
                }

                Console.WriteLine("\n1. Potion ($3)");
                Console.WriteLine("2. Magic Sword ($12)");
                Console.Write("What do you want to buy? ");

                string shopAnswer = Console.ReadLine() ?? "";

                switch (shopAnswer)
                {
                    case "1":
                        if (gold >= 3)
                        {
                            gold -= 3;
                            potion++;

                            Console.WriteLine($"Potion Stock: {potion}");
                            Console.WriteLine($"Gold: {gold}");
                        }
                        else
                        {
                            Console.WriteLine("Not enough gold!");
                        }

                        break;

                    case "2":
                        if (gold >= 12)
                        {
                            gold -= 12;
                            playerAttackPower += 10;
                            playerWeapon = "Magic Sword";

                            Console.WriteLine($"Attack Power: {playerAttackPower}");
                            Console.WriteLine($"Weapon: {playerWeapon}");
                            Console.WriteLine($"Gold: {gold}");
                        }
                        else
                        {
                            Console.WriteLine("Not enough gold!");
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid shop option!");
                        break;
                }

                break;
            }

        case "4":
            Console.WriteLine($"\nWeapon: {playerWeapon}");
            Console.WriteLine($"Potions: {potion}");
            Console.WriteLine($"Gold: {gold}");
            break;

        default:
            Console.WriteLine("Please enter a valid menu option.");
            break;
    }

    Console.WriteLine("========================");
}

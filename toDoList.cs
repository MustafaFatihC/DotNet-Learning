List<string> todo = new List<string>();

List<string> completed = new List<string>();

while (true)
{
    Thread.Sleep(1000);
    System.Console.WriteLine("");
    System.Console.WriteLine("What would you do?");

    System.Console.WriteLine("Enter 1 to add a task to the list.");
    System.Console.WriteLine("Enter 2 to remove a task from the list.");
    System.Console.WriteLine("Enter 3 to view the list.");
    System.Console.WriteLine("Enter 4 to complet a task.");
    System.Console.WriteLine("Enter 5 to completed task.");
    System.Console.WriteLine("Enter e to exit the program.");
    string answer = Console.ReadLine();
    Thread.Sleep(1000);
    if (answer == "1")
    {

        System.Console.Write("Please enter the task ->");
        string task = Console.ReadLine();
        todo.Add(task);
    }
    else if (answer == "2")
    {
        System.Console.Write("Please enter the what you wanna remove ->");
        string remove = Console.ReadLine();
        for (int i = 0; i < todo.Count; i++)
        {
            if (todo[i].Contains(remove))
            {
                System.Console.WriteLine($"Removed!");
                todo.RemoveAt(i);
                break;
            }
            else
            {
                System.Console.WriteLine("Doesn't found!");
            }
        }


    }
    else if (answer == "3")
    {
        System.Console.WriteLine("List");
        foreach (var item in todo)
        {
            System.Console.WriteLine(item);
        }
    }
    else if (answer == "4")
    {
        System.Console.WriteLine("Please ente what is your completed task ->");
        string task = Console.ReadLine();
        for (int j = 0; j < todo.Count; j++)
        {
            if (todo[j].Contains(task))
            {
                System.Console.WriteLine($"{task} completed !");
                completed.Add(task);
                todo.RemoveAt(j);
                break;
            }

        }
    }
    else if (answer == "5")
    {
        System.Console.Write("Completed :");
        foreach (var item in completed)
        {
            System.Console.WriteLine(item);
        }
    }
    else if (answer == "e")
    {
        System.Console.WriteLine("You are quiting the todo program!");
        break;
    }
    else
    {
        System.Console.WriteLine("Please enter a valid key!");
    }

}
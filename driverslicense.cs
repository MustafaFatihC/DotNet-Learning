Console.Write("Please enter your age ->");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("do you have driver's licence (True/False)-> ");
string isLicence = Console.ReadLine();

if (age >= 18 && isLicence == "True")
{
    Console.WriteLine("I take your a few minutes ... (The police officer is loking your criminal record )  ");
    Console.Write("is the person waiting front of you have bad criminal record (Yes/No)-> ");
    string criminalRecord = Console.ReadLine();
    if (criminalRecord == "Yes")
    {
        Console.WriteLine("You get busted!!!");
    }
    else
    {
        Console.WriteLine("Now , you can pass !");
    }
}
else
{
    Console.WriteLine("You can't go ");
    if (age >= 18)
    {
        Console.WriteLine("Could you please step out of the car sir (Sure/Something else)?");
        string answer = Console.ReadLine();
        if (answer == "Sure")
        {
            Console.WriteLine("You have get traffic fine ");
        }
        else
        {
            Console.WriteLine("You get arrested");
        }
    }
    else
    {
        Console.Write("Can you call your parent (Sure/Something else)->");
        string answerParent = Console.ReadLine();
        if (answerParent == "Sure")
        {
            Console.WriteLine("Your parent and u are going to detention center because of you ");
        }
        else
        {
            Console.WriteLine("Your parent and u are going to detention center because of you ");
        }
    }
}
while (true) //! Checks the number value if the value smaller than two gets the number again.
{
    try
    {
        System.Console.Write("Please enter a number :");
        int number = Convert.ToInt32(Console.ReadLine()); //? Get a number from the user
        bool result = true;

        if (number >= 2)
        {

            for (int i = 2; i < number; i++) //? Checking the number can divide the i parameters
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }

            }

            if (result == true) //? checking the result if the result equals true 
            {
                System.Console.WriteLine("Your number is PRİME!");  //? going there
            }
            else
            {
                System.Console.WriteLine("Your number isn't PRİME!"); //? else the result equals false go there 
            }
            break;
        }
        else
        {
            System.Console.WriteLine("Please enter a number unless bigger than two");
        }
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Please enter valid format!");
    }

}



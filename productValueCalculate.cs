
static decimal CalculateTax(decimal price, decimal tax = 20) //* Metodları tanımlama
{

    return price * tax / 100;
}

static decimal CalculateDiscount(decimal price, decimal discount = 0, decimal extraDiscount = 0)
{
    return (price * discount / 100) + (price * extraDiscount / 100);
}

static decimal FinalPrice(decimal price, decimal calculatedTax, decimal calculatedDiscount)
{
    return price + calculatedTax - calculatedDiscount;
}

static decimal ReadDecimal(string message) //! Kullanıcıdan değer alınırken veri tipi sorgulama try-catch ile birlikte de yapılabilirdi!
{
    while (true)
    {
        System.Console.Write(message);
        string input = Console.ReadLine() ?? "";

        if (decimal.TryParse(input, out decimal value))
        {
            return value;
        }
        System.Console.WriteLine("İnvalid input! Please try again!");
    }
}



// //!Methodları çağırma!
// decimal priceTax = CalculateTax(productValue, taxValue);
// decimal discountPrice = CalculateDiscount((priceTax + productValue), discountValue);
// decimal finalPrice = FinalPrice(productValue, priceTax, discountPrice);
// //!Methodları yazdırma!
// System.Console.WriteLine($"\n Tax price :{priceTax} \n Discount price : {discountPrice} \n Final Price : {finalPrice}");

string mainAnswer;

while (true)
{

    try
    {

        System.Console.Write("Did you have extra discount(y/n || yes/no) :");
        string answer = (Console.ReadLine() ?? "").Trim().ToLower();


        if (answer == "y" || answer == "yes")
        {
            mainAnswer = answer;

        }
        else if (answer == "n" || answer == "no")
        {
            mainAnswer = answer;

        }
        else
        {
            throw new FormatException();
        }
        break;

    }
    catch (FormatException)
    {
        System.Console.WriteLine("Please enter valid input (y/n) !");
    }

}

if (mainAnswer == "y")
{
    decimal productValue = ReadDecimal("Please enter  product value:");

    decimal taxValue = ReadDecimal("Please enter tax value:");

    decimal discountValue = ReadDecimal("Please enter discount value:");

    decimal eXtraDiscount = ReadDecimal("Please enter extra discount value:");

    //!Methodları çağırma!
    System.Console.WriteLine("Final price with extra discount");
    decimal priceTax = CalculateTax(productValue, taxValue);
    decimal discountPrice = CalculateDiscount((priceTax + productValue), discountValue, eXtraDiscount);
    decimal finalPrice = FinalPrice(productValue, priceTax, discountPrice);
    //!Methodları yazdırma!
    System.Console.WriteLine($"\n Tax price :{priceTax} \n Discount price : {discountPrice} \n Final Price : {finalPrice}");

}
else
{

    decimal productValue = ReadDecimal("Please enter  product value:");

    decimal taxValue = ReadDecimal("Please enter tax value:");

    decimal discountValue = ReadDecimal("Please enter discount value:");

    //!Methodları çağırma!
    System.Console.WriteLine("Final price with discount");
    decimal priceTax = CalculateTax(productValue, taxValue);
    decimal discountPrice = CalculateDiscount((priceTax + productValue), discountValue);
    decimal finalPrice = FinalPrice(productValue, priceTax, discountPrice);
    //!Methodları yazdırma!
    System.Console.WriteLine($"\n Tax price :{priceTax} \n Discount price : {discountPrice} \n Final Price : {finalPrice}");

}

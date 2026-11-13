
static decimal CalculateTax(decimal price, decimal tax = 20) //* Metodları tanımlama
{

    return price * tax / 100;
}

static decimal CalculateDiscount(decimal price, decimal discount = 0)
{
    return price * discount / 100;
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


decimal productValue = ReadDecimal("Please enter  product value:");


decimal taxValue = ReadDecimal("Please enter tax value:");


decimal discountValue = ReadDecimal("Please enter discount value:");


//!Methodları çağırma!
decimal priceTax = CalculateTax(productValue, taxValue);
decimal discountPrice = CalculateDiscount((priceTax + productValue), discountValue);
decimal finalPrice = FinalPrice(productValue, priceTax, discountPrice);
//!Methodları yazdırma!
System.Console.WriteLine($"\n Tax price :{priceTax} \n Discount price : {discountPrice} \n Final Price : {finalPrice}");



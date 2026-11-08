Dictionary<string, decimal> products = new Dictionary<string, decimal>();
Dictionary<string, int> stocks = new Dictionary<string, int>();
Dictionary<string, int> orderStocks = new Dictionary<string, int>();
Dictionary<string, decimal> orderHistory = new Dictionary<string, decimal>();//? Sipariş sepeti 
List<decimal> buyingHistory = new List<decimal>(); //? Satın alma geçmişi 

products.Add("Keyboard", 1500);
products.Add("Mouse", 1500);
products.Add("Headset", 1500);
products.Add("Monitor", 1500);
products.Add("Laptop", 1500);

stocks.Add("Keyboard", 10);
stocks.Add("Mouse", 15);
stocks.Add("Headset", 5);
stocks.Add("Monitor", 8);
stocks.Add("Laptop", 3);





bool isRunning = true;
decimal totalCart = 0;



while (true && isRunning)
{
    System.Console.WriteLine("1. View Products");
    System.Console.WriteLine("2. Add Product to Cart");
    System.Console.WriteLine("3. Remove Product from Cart");
    System.Console.WriteLine("4. View Shopping Cart");
    System.Console.WriteLine("5. Checkout");
    System.Console.WriteLine("6. View Order History");
    System.Console.WriteLine("E. Exit");

    System.Console.WriteLine("Please enter your option: ");
    string answer = Console.ReadLine();

    switch (answer)
    {
        case "1":

            foreach (var product in products)
            {
                System.Console.WriteLine($"Product item Name : {product.Key} , item Value : {product.Value}");
            }
            break;

        case "2":


            System.Console.WriteLine("Please enter product name:");
            string itemName = Console.ReadLine();

            decimal itemValue = products[itemName];

            System.Console.WriteLine("How many do you want:");
            int itemStock = Convert.ToInt32(Console.ReadLine());

            if (orderHistory.ContainsKey(itemName))
            {
                orderStocks[itemName] += itemStock;
            }
            else
            {
                orderHistory.Add(itemName, itemValue);
                orderStocks.Add(itemName, itemStock);
            }



            break;

        case "3":

            System.Console.WriteLine("Please enter product name which one do you remove: ");
            string itemRemoveName = Console.ReadLine();

            if (orderHistory.ContainsKey(itemRemoveName))
            {
                orderHistory.Remove(itemRemoveName);
                orderStocks.Remove(itemRemoveName);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }

            break;
        case "4":

            foreach (var order in orderHistory)
            {

                System.Console.WriteLine($"Product item Name : {order.Key} , item Value : {order.Value}");

            }

            break;
        case "5":
            foreach (var order in orderHistory)
            {
                totalCart += order.Value * orderStocks[order.Key];
                stocks[order.Key] -= orderStocks[order.Key];
            }

            System.Console.WriteLine($"Your Cart total is {totalCart}");

            buyingHistory.Add(totalCart);



            totalCart = 0;
            orderHistory.Clear();
            orderStocks.Clear();

            break;

        case "6":
            foreach (var buy in buyingHistory)
            {
                System.Console.WriteLine(buy);
            }
            break;

        case "E":
            System.Console.WriteLine("You are quiting the Online Shopping! ");
            Thread.Sleep(1000);
            isRunning = false;
            break;
        default:
            System.Console.WriteLine("Please enter valid menu operation!");
            break;

    }
}
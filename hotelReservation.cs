Dictionary<string, string> rooms = new Dictionary<string, string>();
Dictionary<string, string> reservedRooms = new Dictionary<string, string>();

rooms.Add("101", "Available");
rooms.Add("102", "Available");
rooms.Add("103", "Available");
rooms.Add("104", "Available");
rooms.Add("105", "Available");

int roomPrice = 1000;

System.Console.WriteLine("=================");
System.Console.WriteLine("Welcome to Hotel Reservation System!");

while (true)
{
    Console.WriteLine("\n1. View Rooms");
    Console.WriteLine("2. Book a Room");
    Console.WriteLine("3. Cancel Reservation");
    Console.WriteLine("4. View Reservations");
    Console.WriteLine("5. Calculate Total Revenue");
    Console.WriteLine("6. Exit");

    Console.Write("What do you want -> ");
    string answer = Console.ReadLine() ?? "";

    if (answer == "6")
    {
        Console.WriteLine("You are quitting!");
        break;
    }

    switch (answer)
    {
        case "1":
            foreach (var room in rooms)
            {
                Console.WriteLine(
                    $"Room no: {room.Key} | Status: {room.Value}");
            }

            System.Console.WriteLine("=================");

            break;

        case "2":
            Console.Write("Please enter room number: ");
            string roomNum1 = Console.ReadLine() ?? "";

            if (!rooms.ContainsKey(roomNum1))
            {
                Console.WriteLine("Room number isn't valid!");
            }
            else if (rooms[roomNum1] == "Reserved")
            {
                Console.WriteLine("This room is already reserved!");
            }
            else
            {
                rooms[roomNum1] = "Reserved";
                reservedRooms.Add(roomNum1, "Reserved");
                Console.WriteLine("Room reserved successfully!");
            }

            System.Console.WriteLine("=================");

            break;

        case "3":
            Console.Write("Enter the room number to cancel: ");
            string roomNum2 = Console.ReadLine() ?? "";

            if (!reservedRooms.ContainsKey(roomNum2))
            {
                Console.WriteLine("This room has no reservation!");
            }
            else
            {
                rooms[roomNum2] = "Available";
                reservedRooms.Remove(roomNum2);
                Console.WriteLine("Reservation cancelled successfully!");

            }

            System.Console.WriteLine("=================");

            break;

        case "4":
            if (reservedRooms.Count == 0)
            {
                Console.WriteLine("There are no reservations.");

            }
            else
            {
                foreach (var room in reservedRooms)
                {
                    Console.WriteLine($"Reserved room: {room.Key}");
                }
            }

            System.Console.WriteLine("=================");

            break;

        case "5":
            int totalPrice = roomPrice * reservedRooms.Count;

            Console.WriteLine($"Total reservation revenue: {totalPrice}");

            System.Console.WriteLine("=================");
            break;

        default:

            Console.WriteLine("Invalid menu option!");

            System.Console.WriteLine("=================");
            break;
    }
}

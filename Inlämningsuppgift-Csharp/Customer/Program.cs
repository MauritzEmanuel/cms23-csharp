using Assingment.Services;

var runAgain = true;
do
{
    Console.Clear();
    Console.WriteLine("1. Skapa en kund");
    Console.WriteLine("2. Skriv ut alla kunder");
    Console.WriteLine("3. Ändra en kund");
    Console.WriteLine("4. Avsluta programmet");

    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Clear();
            CustomerService.CreateCustomer();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;
        case "2":
            Console.Clear();
            CustomerService.GetCustomers();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;
        case "4":
            runAgain = false;
            break;
        default:
            break;
    }
}
while (runAgain == true);
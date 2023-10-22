using Assingment.Models;
using Assingment.Services;

var runAgain = true;

//Skapar en instans av CustomerService då CreateCustomer inte är static
CustomerService customerService = new CustomerService();

do
{
    Console.Clear();
    Console.WriteLine("1. Skapa en kund");
    Console.WriteLine("2. Skriv ut alla kunder");
    Console.WriteLine("3. Skriv ut specifik kund");
    Console.WriteLine("4. Ta bort en kund");
    Console.WriteLine("5. Avsluta programmet");

    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Clear();
            customerService.CreateCustomer(new Customer());
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;
        case "2":
            Console.Clear();
            CustomerService.ViewAllCustomers();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;
        case "3":
            Console.Clear();
            CustomerService.ViewOneCustomer();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;
        case "4":
            Console.Clear();
            CustomerService.RemoveOneCustomerMenu();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            break;
        case "5":
            runAgain = false;
            break;
        default:
            break;
    }
}
while (runAgain == true);
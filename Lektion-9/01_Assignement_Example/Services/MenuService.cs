using _01_Assignement_Example.Interfaces;
using _01_Assignement_Example.Models;

namespace _01_Assignement_Example.Services;

public class MenuService
{

    private static readonly ICustomerService customerService = new CustomerService();

    public static void AddCustomerMenu()
    {
        ICustomer customer = new Customer();

        Console.Write("Förnamn: ");
        customer.FirstName = Console.ReadLine();
        Console.Write("Efternamn: ");
        customer.LastName = Console.ReadLine();
        Console.Write("Email: ");
        customer.Email = Console.ReadLine();

        customer.Address = new Address();
        Console.Write("Gatuadress: ");
        customer.Address.StreetName = Console.ReadLine();
        Console.Write("Gatunummer: ");
        customer.Address.StreetNumber = Console.ReadLine();
        Console.Write("Postnummer: ");
        customer.Address.PostalCode = Console.ReadLine();
        Console.Write("Stad/Ort: ");
        customer.Address.City = Console.ReadLine();

        customerService.AddCustomerAsync(customer);
    }

    public static void ViewAllCustomers()
    {
        var customers = customerService.GetAllCustomers();
        foreach (var customer in customers)
        {
            Console.WriteLine(customer.FullName);
            Console.WriteLine(customer.Address?.FullAdress);
            Console.WriteLine();
        }
    }

    public static void ViewOneCustomerMenu()
    {
        Console.Write("E-postadress: ");
        var email = Console.ReadLine();

        var customer = customerService.GetOneCustomer(email!);

        Console.WriteLine(customer.FullName);
        Console.WriteLine(customer.Address.FullAdress);
        Console.WriteLine();
    }

    public static void RemoveOneCustomer()
    {
        Console.Write("E-postadress: ");
        var email = Console.ReadLine();

        customerService.RemoveCustomer(email);
    }

    public static async Task MainMenuAsync()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("1. Skapa en ny kund");
            Console.WriteLine("2. Visa alla kunder");
            Console.WriteLine("3. Visa en kund");
            Console.WriteLine("4. Ta bort en kund");
            Console.WriteLine("0. Avsluta");
            Console.Write("Välj något av de följande alternativen: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddCustomerMenu();
                    break;
                case "2":
                    ViewAllCustomers();
                    break;
                case "3":
                    ViewOneCustomerMenu();
                    break;
                case "4":
                    RemoveOneCustomer();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
            }

            Console.ReadKey();
        }
        while (true);
    }
}

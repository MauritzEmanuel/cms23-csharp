using Assingment.Models;
using Newtonsoft.Json;

namespace Assingment.Services;

internal class CustomerService
{
    private static List<Customer> customerList = new List<Customer>();
    private static List<Addresses> addressList = new List<Addresses>();


    //metod för att skapa kontakter
    public static void CreateCustomer()
    {
        Customer customer = new Customer();

        Console.WriteLine("Ange förnamn: ");
        customer.FirstName = Console.ReadLine() ?? "";
        Console.WriteLine("Ange efternamn: ");
        customer.LastName = Console.ReadLine() ?? "";
        Console.WriteLine("Ange e-postadress: ");
        customer.Email = Console.ReadLine() ?? "";
        Console.WriteLine("Ange telefonnummer: ");
        customer.PhoneNumber = Console.ReadLine() ?? "";
        Console.WriteLine("Ange hemadress: ");

        var choice = "";
        Console.WriteLine("Vill du lägga till en Address?");
        Console.WriteLine("1. Ja");
        Console.WriteLine("2. Nej");

        choice = Console.ReadLine();

        if (choice == "1")
            CreateAdress();


        customerList.Add(customer);

        //Sparar kontakten i en fil
        FileService.SaveToFile(JsonConvert.SerializeObject(customerList));
        Console.WriteLine("En ny kund har lagts till i listan");
    }



    public static void CreateAdress()
    {
        Addresses address = new Addresses();

        Console.WriteLine("Ange gatunamn: ");
        address.StreetName = Console.ReadLine() ?? "";
        Console.WriteLine("Ange gatunummer: ");
        address.StreetNumber = Console.ReadLine() ?? "";
        Console.WriteLine("Ange Stad/Ort: ");
        address.City = Console.ReadLine() ?? "";
        Console.WriteLine("Ange postnummer: ");
        address.PostalCode = Console.ReadLine() ?? "";

        addressList.Add(address);
    }


    //Metod för att skriva ut Kontaktlistan
    public static void GetCustomers()
    {
        foreach (var customer in customerList)
        {
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.Email);
            Console.WriteLine(customer.PhoneNumber);
            Console.WriteLine(customer.Address);
            Console.WriteLine();
        }
    }
}
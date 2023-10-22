using Assingment.Models;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace Assingment.Services;

public class CustomerService
{
    private static List<Customer> customerList = new List<Customer>();


    //metod för att skapa kontakter
    public void CreateCustomer(Customer customer)
    {

        Console.WriteLine("Ange förnamn: ");
        customer.FirstName = Console.ReadLine() ?? "";
        Console.WriteLine("Ange efternamn: ");
        customer.LastName = Console.ReadLine() ?? "";
        Console.WriteLine("Ange e-postadress: ");
        customer.Email = Console.ReadLine() ?? "";
        Console.WriteLine("Ange telefonnummer: ");
        customer.PhoneNumber = Console.ReadLine() ?? "";

        customer.Address = CreateAdress();


        customerList.Add(customer);

        //Sparar kontakten i en fil
        FileService.SaveToFile(JsonConvert.SerializeObject(customerList));
        Console.WriteLine("En ny kund har lagts till i listan");
    }


    //Addresses får en egen metod för att sortera ut koden
    public static Addresses CreateAdress()
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

        return address;
    }


    //Metod för att skriva ut Kontaktlistan
    public static void ViewAllCustomers()
    {
        foreach (var customer in customerList)
        {
            Console.WriteLine("Personuppgifter:");
            Console.WriteLine(customer.FullName);
            Console.WriteLine(customer.Email);
        }
    }

    //GetOneCustomer och GetCustomerList är till för att andra metoder ska få tag på informationen från listorna
    public Customer GetOneCustomer(string email)
    {
        return customerList.FirstOrDefault(x => x.Email == email)!;
    }

    public List<Customer> GetCustomerList()
    {
        return customerList;
    }


    //Metod för att skriva ut detaljerad information om en specifik kund
    public static void ViewOneCustomer()
    {
        CustomerService customerService = new CustomerService();

        Console.WriteLine("Skriv in kundens e-postadress");
        var email = Console.ReadLine();

        var specifikCustomer = customerService.GetOneCustomer(email);

        if (specifikCustomer != null)
        {
            Console.WriteLine();
            Console.WriteLine("Personuppgifter:");
            Console.WriteLine(specifikCustomer.FullName);
            Console.WriteLine(specifikCustomer.Email);
            Console.WriteLine(specifikCustomer.PhoneNumber);
            Console.WriteLine();
            Console.WriteLine("Hemaddress:");
            Console.WriteLine(specifikCustomer.Address.FullAddress);
        }
        else
            Console.WriteLine("Kunden hittades inte");

    }

    public static void RemoveOneCustomerMenu()
    {
        Console.WriteLine("Skriv in kundens e-postadress");
        var email = Console.ReadLine();

        CustomerService customerService = new CustomerService();
        customerService.RemoveCustomer(email!);

    }

    private void RemoveCustomer(string email)
    {
        var customer = GetOneCustomer(email);

        //Ser till att programmet inte kraschar om din inmatning inte finns med i listan
        if (customer != null)
        {
            customerList.Remove(customer);
            Console.WriteLine("Kunden är borttagen.");
        }
        else
            Console.WriteLine("Kunden hittades inte");

    }
}
/* Json = JavaScript Object Notation
 
    "key": "value"

    {
        "firstName": "Emanuel",
        "lastName": "Lundbergh",
        "age": "20",
        "isActive": false,
        "skills": ["C#", "JS", "Python", "C"],
        "relatives": [
        {"firstName": "Tommy", "lastName": "Mattin-Lassei"},
        {"firstName": "Anki", "lastName": "Mattin-Lassei"}
                    ]
    }
 
 
 */



using _02_SaveAndReadToFromFile.Models;
using _02_SaveAndReadToFromFile.Services;

var customerService = new CustomerService();
customerService.GetCustomers();

var customer = new Customer
{
    FirstName = "Emanuel",
    LastName = "Lundbergh",
    Email = "Supermejl@gmail.com"
};

//customerService.AddToList(customer);


Console.ReadKey();
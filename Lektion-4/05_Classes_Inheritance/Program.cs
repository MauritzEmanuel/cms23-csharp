using _05_Classes_Inheritance.Methods;
using _05_Classes_Inheritance.Services;

/*
var privateCustomer = new PrivateCustomer()
{
    Id = Guid.NewGuid(),
    Created = DateTime.Now,
    Modified = DateTime.Now,
    Email = "TestMail",

    FirstName = "Emanuel",
    LastName = "Lundbergh",
    Phone = "1234567890",
};

var companyCustomer = new CompanyCustomer()
{
    Id = Guid.NewGuid(),
    Created = DateTime.Now,
    Modified = DateTime.Now,
    Email = "TestMail",

    CompanyName = "Nackademin",
    Phone = "1234567890",
};

*/

var runAgain = false;

do
{
    Console.Clear();
    Console.WriteLine("Vad för typ av kund vill du skapa (p = privatperson, f = företag: ");
    var option = Console.ReadLine();

    switch (option?.ToLower())
    {
        case "p":
            CustomerService.CreatePrivateCustomer();
            break;

        case "f":
            CustomerService.CreateCompanyCustomer();
            break;

        default:
            break;
    }

    Console.Write("Vill du fortsätta (j/n): ");
    runAgain = (Console.ReadLine()!.ToLower() == "j") ? true : false;
}
while (runAgain);

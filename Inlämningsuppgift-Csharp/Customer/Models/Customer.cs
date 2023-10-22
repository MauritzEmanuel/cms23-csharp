namespace Assingment.Models;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set;} = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public Addresses Address { get; set; } = null!;

    //Skapar FullName för att koden ska bli mindre komplex
    public string FullName => $"{FirstName} {LastName}";
}
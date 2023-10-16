namespace _05_Classes_Inheritance.Methods;

internal class PrivateCustomer : Customer
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set;} = null!;
    public string? Phone { get; set; }
}

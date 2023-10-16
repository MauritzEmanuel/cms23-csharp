namespace _02_Classes_GettersAndSetters.Models;

internal class Customer
{
    public string FirstName { get; set; }
	public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";
}

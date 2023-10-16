namespace _01_Assignement_Example.Interfaces
{
    public interface IAddress
    {
        string? City { get; set; }
        string? PostalCode { get; set; }
        string? StreetName { get; set; }
        string? StreetNumber { get; set; }
        string? FullAdress { get; }
    }
}
﻿namespace Assingment.Models;

public class Addresses
{
    public string StreetName { get; set; } = null!;
    public string StreetNumber { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

    //Skapar FullAddress för att koden ska bli mindre komplex
    public string FullAddress => $"{StreetName} {StreetNumber}, {PostalCode}, {City}";
}

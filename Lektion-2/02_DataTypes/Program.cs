/* 
    C# Variabler

    long            Till för väldigt långa heltal
   * decimal         Till för decimaltal             decimal length = 39.8m;
    double          Till för decimaltal
   * bool            Till för sant/falskt            bool isHuman = true;
    char            Till för enskilt tecken         char gender = 'M';
    dynamic         kan innehålla vad som           dynamic lastName = "Mattin-Lassei";
                                                                    dynamic weight = 90.0;
   * Guid            globalt unikt vid               Guid id = Guid.NewGuid();
    byte
   * null            är ingenting
    object 
 */

/*
    Deklarera variabler i C#

    Hur skriver vi varibal namn
    
    camelCase       firstName       string firstName = "Mauritz";
    Pascal          FirstName       string FirstName = "Mauritz";
    kebab-case      first-name      string first-name = "Mauritz";
    snake_case      first_name      string first_name = "Mauritz";

    C# använder sig primärt av Pascal men även camelCase

    korrekt sätt att deklarera:         string firstName = "Mauritz";
    Latmanssättet att deklarera:        var firstName = "Mauritz";

 
 */

/*
    String - textvärden

    string firstName = "Mauritz";
    var lastName = "Lundbergh";


var firstName = "Emanuel";
var lastName = "Lundbergh";

string sentence = "Jag heter Mauritz och jag är \"bäst\".";

string url_1 = "c:\\education\\cms23-csharp";
string url_2 = @"c:\education\cms23-csharp";

string placeholder_1 = "Hej jag heter " + firstName + " " + lastName;
string placeholder_1 = $"Hej jag heter {firstName} {lastName}";
string placeholder_3 = string.Format("Hej jag heter {0} {1].", firstName, lastName);

 */

Console.Write("Skriv ditt förnamn: ");
string firstName = Console.ReadLine() ?? "";

Console.Write("Skriv ditt efternamn: ");
string lastName = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Hej {firstName} {lastName}.");
Console.ReadKey();

//Uppsala boysen
Console.WriteLine("Eric");
Console.WriteLine("Alex");
Console.WriteLine("Emanuel");

//Botkyrkas chef
Console.WriteLine("Yasin");

Console.ReadKey();
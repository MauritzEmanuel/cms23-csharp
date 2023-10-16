/* String - till för text

string firstName = "Emanuel";
var lastName = "Lundbergh"


string firstName = "Emanuel";
var lastName = "Lundbergh";
string sentence = "Jag är \"Bäst\"";
string uri = @"c:\users\Emanuel\documents";

string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
string placeholder_2 = $"Hej jag heter {firstName} {lastName}.";

Console.WriteLine(placeholder_2);


string firstName = "Marre ";
string email = "Emanuel@gmail.com";
string lastName = "Lundbergh";

Console.WriteLine($"Original: {email}");
Console.WriteLine($"ToUpper: {email.ToUpper()}");

Console.WriteLine($"{firstName.Trim()} {lastName.Trim()}");

string sentence = "Här har vi en text som är på svenska";
Console.WriteLine(sentence.Replace("ä", "a").Replace("å", "a"));

string name = "Emanuel Lundbergh";
string domain = "domain.com";
string emailadress = $"{name}@{domain}";

Console.WriteLine(emailadress);
emailadress = emailadress.Replace(" ", ".".ToLower());
Console.WriteLine(emailadress);

*/

/*
    INTERGRALS & FLOATING POINTS
    -----------------------------------------------------------------------------------------------

    Type        Bits        Range (min, max)
    -----------------------------------------------------------------------------------------------
   * byte       8           0               255
    sbyte       8           -128            127
    short       16          -32768          32767
    ushort      16          0               65535
   * int        32          -2147483648     2147483647
    uint        32          0               4294967295
   * long       64          -väldigt mycket väldigt mycket
    ulong       64          0               extremt mycket



    Type        Bytes       Decimal Range           Sufix
    ------------------------------------------------------------------------------------------------
    float       4           6-9 digits              f eller F
    double      8           15-16 digits            inget eller d eller D
   * decimal     16          28-29 digits            m eller M
 

float floatValue = 0.1f + 0.1f + 0.1f;      //0.3
Console.WriteLine(floatValue);

double doubleValue = 0.1 + 0.1 + 0.1;       //0.3000000004 ungefär
Console.WriteLine(doubleValue);

decimal decimalValue = 0.1m + 0.1m + 0.1m;  //0.3
Console.WriteLine(decimalValue);

*/

/*
        BOOLEAN - sant/falskt

        TYPE            BITS
        -----------------------------------------------------------
        bool            0/1         false/true


        bool isEnabled = false;
        bool isActive = true;
 */

/*
        GUID/UUID (Globally Unique Identifier)      (Skapar en användare)
        ----------------------------------------------------------------------------
        Guid            16 bytes            Guid.NewGuid();

 
        Guid userId = Guid.NewGuid();
        Console.WriteLine(userId);
 
 */


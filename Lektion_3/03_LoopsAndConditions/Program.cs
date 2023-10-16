/*
    Operander
    ----------------------------------------
    ==      lika med
    !=      inte lika med
    <       mindre än
    >       mer än
    <=      lika med eller mindre
    >=      lika med eller mer
    &&      och
    ||      eller
    !       inte
    ??      om första värdet är null välj det andra



    if (statement) {}
    if (statement) {} else {}
    if (statement) {} else if {} else {}

    (statement) ? do_this : else_do_this;


string name = "Emanuel";
string firstName = "Tommy";

if (!string.IsNullOrEmpty(firstName))
    Console.WriteLine("Vi gör något med namnet");
else
    Console.WriteLine("Det finns inget förnamn");


string firstName = "Maurizz";
string lastName = "";

int tal;
tal =+ 10;

Console.WriteLine(tal);

if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
    Console.WriteLine("Något av värdena är inte ifyllda");

*/

/* SWITCH
string key = "black";

switch (key)
{
    case "blue":
        Console.WriteLine("Unlock blue door");
        break;
    case "orange":
        Console.WriteLine("Unlock orange door");
        break;
    case "gray":
        Console.WriteLine("Unlock gray door");
        break;
    default: 
        Console.WriteLine("Go through white door0");
        break;
}
/*

/*  FOR LOOP
-----------------------------------------------------------------
    Vi loopar igenom en lista eller gör något ett givet antal gånger

    for (int i = 0; i < 10, i++)
    {

    }

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"i: {i}");
    }
 */

/*  FOREACH LOOP
    -----------------------------------------------------
    Vi loopar igenom alla objekt i en lista

    foreach (var object in list)
    {
    }
 
 */

/*  ARRAYS
    --------------------------------------------------------------
    Array är en lista med bestämt antal platser
 
    string[] names = new string[] { "Emanuel", "Mauritz", "Marre" };

    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
 
 */

/*  WHILE
    ---------------------------------------------------
    gör en sak om och om igen tills ett tillstånd är uppnått
    varav kontrollen sker i början

    int number = 0;
    while (number < 10)
    {

    }
 

    i++
    i--
    ++i
    --i
 */

 /* DO-WHILE LOOP
    ---------------------------------------
    while loop där den checkar i slutet och kör minst en gång

    do
    {
    } while (statement);  
  
  
  */

int number = 0;
while (number < 10)
{
    Console.WriteLine(number);
    number++;
}
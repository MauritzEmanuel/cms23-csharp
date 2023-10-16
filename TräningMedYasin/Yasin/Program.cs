//Variabler
int ålder = 20;
int åldersgräns = 18;

bool ålderGodkänd;

//Här startar programmet
Console.WriteLine("Välkommen till kiosken, åldersgränsen på cigg är 18 år.");

//Kollar om åldern är godkänd
if (ålder < åldersgräns)
    ålderGodkänd = false;
else
    ålderGodkänd = true;

//Skriver ut om du får eller inte får köpa cigg
if (ålderGodkänd == true)
    Console.WriteLine("Du får köpa!");
else
    Console.WriteLine("Du är för ung tyvärr");


Console.ReadKey();
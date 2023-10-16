using _02_Structs.Structs.Domain_Driven_Design;
using _02_Structs.Structs.Interoperability;
using _02_Structs.Structs.Mathematical_Models;
using _02_Structs.Structs.Performance_Sensitive;
using _02_Structs.Structs.Valve__Semantics;

//Matematiska modeller
Vector2d vector = new Vector2d(3.0, 4.0);
Console.WriteLine($"Vector X={vector.X}, Y={vector.Y}");
Console.ReadKey();

//Interoperabilitet
var todo = new Todo() { userId = 1, id = 1, title = "delectus aut autem", completed = false };
Console.WriteLine($"Todo: {todo.id}, - {todo.title}");


//prestanda känsliga applikationer
RgbColor color = new RgbColor(255, 0, 0);
Console.WriteLine($"Color R={color.R}, G={color.G}, ={color.B}");
Console.ReadKey();

//Värdesemantik
Money salary = new Money(5000M, "sek");
Console.WriteLine($"Money: Amount={salary.Amount}, Currency={salary.Currency}");
Console.ReadKey();

//Domain driven design (DDD)
var user = new User
{
    FirstName = "Emanuel",
    LastName = "Lundbergh",
    Email = new Email("Emanuel@gmail.com"),
    Password = new Password("BytMig123")
};
Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
Console.ReadKey();
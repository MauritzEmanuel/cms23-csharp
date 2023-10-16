using _01_Exercise.Interfaces;
using _01_Exercise.Models;
using System.ComponentModel.DataAnnotations;

namespace _01_Exercise.Services;


internal interface IMenuService
{
    public void MainMenu();
    public void CreateMenu();
    public void ListAllMenu();
    public void ListSpecificMenu();
}

internal class MenuService : IMenuService

{
    //Bara den funktionallitet i kontraktet komms åt
    private readonly IUserService userService = new UserService();
    public void CreateMenu()
    {
        Console.Clear();
        Console.WriteLine("Skapa en ny användare");
        Console.WriteLine("---------------------");

        var user = new UserCreateRequest();
        Console.Write("Förnamn: ");
        user.FirstName = Console.ReadLine()!.Trim();

        Console.Write("Efternamn: ");
        user.LastName = Console.ReadLine()!.Trim();

        Console.Write("E-postadress: ");
        user.Email = Console.ReadLine()!.Trim().ToLower();

        Console.Write("Lösenord: ");
        user.Password = Console.ReadLine()!.Trim();

    }

    public void ListAllMenu()
    {
        throw new NotImplementedException();
    }

    public void ListSpecificMenu()
    {
        throw new NotImplementedException();
    }

    public void MainMenu()
    {
        var exit = false;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Skapa en ny användare");
            Console.WriteLine("2. Visa en specifik användare");
            Console.WriteLine("3. Visa alla användare");
            Console.WriteLine("0. Avlsuta");
            Console.WriteLine("Välj ett av oavstådende alternativ (0-3): ");
            var option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    CreateMenu();
                    break;
                case "2":
                    ListSpecificMenu();
                    break;
                case "3":
                    ListAllMenu();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    break;

            }
        }
        while (exit == false);
    }
}

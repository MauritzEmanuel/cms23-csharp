using _01_repitition.Interfaces;
using _01_repitition.Models;

namespace _01_repitition.Services;

internal class MenuService : IMenuService
{
    private readonly IToDoService _todoService = new ToDoService();

    public void AddMenu()
    {
        var todo = new ToDo();

        Console.Clear();
        Console.Write("Ange aktivitet: ");
        todo.Activity = Console.ReadLine();

        _todoService.Add(todo); 
    }

    public void DeleteMenu()
    {
        Console.Clear();
        Console.WriteLine("Ange id: ");
        var id = Console.ReadLine()!;

        //Använd gärna try catch typ överallt så att programmet inte bara kraschar.
        try
        {
            _todoService.Delete(new Guid(id));
        }
        catch (Exception ex) { }
    }

    public void ListMenu()
    {
        Console.Clear();
        Console.WriteLine("ATT-GÖRA-LISTAN");
        Console.WriteLine("-----------------------");

        foreach(var todo in _todoService.GetAll())
        {
            Console.WriteLine($"{todo.Activity}");
            Console.WriteLine($"{todo.Id} - {todo.Created}");
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    public void MainMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("ATT GÖRA-LISTAN");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Lägg till ny aktivitet");
            Console.WriteLine("2. Visa alla aktiviteter");
            Console.WriteLine("3. Ta bort en aktivitet");
            var option = Console.ReadLine();

            //Skriver du inte in någon default så kommer den fortsätta loopa switchen ifann inget case stämmer
            switch(option)
            {
                case "1":
                    AddMenu();
                    break;
                case "2":
                    ListMenu();
                    break;
                case "3":
                    DeleteMenu();
                    break;
            }

        } while (true);
    }
}

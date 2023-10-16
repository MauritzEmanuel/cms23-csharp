namespace _02_AsyncAwait.Services;

internal class MenuService
{
    public record User(string Name, string Email);
    public void AddUser()
    {
        var user = new User("Emanuel", "Emanuel@gmail.com");
        Console.WriteLine("Starting...");


        Task.Run(async () => await UserService.SaveUserAsync(user));

        Console.WriteLine("Nåt händer");
    }
}

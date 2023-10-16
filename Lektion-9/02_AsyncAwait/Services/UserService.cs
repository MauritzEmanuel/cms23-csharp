using static _02_AsyncAwait.Services.MenuService;

namespace _02_AsyncAwait.Services;

internal class UserService
{
    public static async Task SaveUserAsync(User user)
    {
        await Task.Delay(15000);
    }
}

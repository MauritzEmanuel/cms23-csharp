using _01_Exercise.Interfaces;
using _01_Exercise.Models;
using System.Linq;
using System.Linq.Expressions;

namespace _01_Exercise.Services;

internal class UserService : IUserService
{
    private List<User> _users = new List<User>();

    public void Create(UserCreateRequest userCreateRequest)
    {
        _users.Add(new User
        {
            Id = Guid.NewGuid(),
            FirstName = userCreateRequest.FirstName,
            LastName = userCreateRequest.LastName,
            Email = userCreateRequest.Email,
        });

        // Lösenordet får vi hantera separat, av säkerhetsskäl...
    }

    public User Get(Func<User, bool> expression)
    {
        /*
         Kan skrivas på annat sätt: var user = _users.FirstOrDefault(expression, null!);
         return user;
        */

        var user = _users.FirstOrDefault(expression);
        if (user != null)
            return user;
        
        return null!;
    }

    //public User Get(Expression<Func<User, bool>> expression)
    //{
    //    throw new NotImplementedException();
    //}

    public IEnumerable<User> GetAll()
    {
        return _users;
    }
}

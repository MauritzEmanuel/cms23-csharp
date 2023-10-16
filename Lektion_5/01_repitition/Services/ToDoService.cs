using _01_repitition.Interfaces;
using _01_repitition.Models;

namespace _01_repitition.Services;

internal class ToDoService : IToDoService
{
    private readonly List<ToDo> _list = new List<ToDo>();

    public void Add(ToDo todo)
    {
        _list.Add(todo);
    }

    public void Delete(Guid id)
    {
        var todo = _list.FirstOrDefault(x => x.Id == id);
        if (todo != null)
            _list.Remove(todo);
    }

    public IEnumerable<ToDo> GetAll()
    {
        return _list.OrderByDescending(todo => todo.Created);
    }
}

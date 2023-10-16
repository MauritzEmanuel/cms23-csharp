using _03_TodoList.Interfaces;
using System.Diagnostics;

namespace _03_TodoList.Services;

internal class TodoServices : ITodoService
{
    private List<ITodo> _todos = new List<ITodo>();

    public bool AddTodo(ITodo todo)
    {
        try
        {
            TodoServices.Add(todo);
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

    private static void Add(ITodo todo)
    {
        throw new NotImplementedException();
    }

    public bool DeleteTodo(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ITodo> GetAllTodos()
    {
        throw new NotImplementedException();
    }
}

using _03_TodoList.Interfaces;

namespace _03_TodoList.Tests.UnitTests
{
    internal interface ITodoService
    {
        bool AddTodo(ITodo todo);
        IEnumerable<ITodo> GetAllTodos();
    }
}
namespace _03_TodoList.Interfaces;

internal interface ITodoService
{
    bool AddTodo(ITodo todo);
    IEnumerable<ITodo> GetAllTodos();
    bool DeleteTodo(Guid id);
}

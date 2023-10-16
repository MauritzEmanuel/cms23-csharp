using _03_TodoList.Interfaces;

namespace _03_TodoList.Models;

public class Todo : ITodo
{
    public Guid id { get; set; }

}

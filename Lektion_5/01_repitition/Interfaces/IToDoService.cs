using _01_repitition.Models;

namespace _01_repitition.Interfaces;

internal interface IToDoService
{
    void Add(ToDo todo);
    IEnumerable<ToDo> GetAll();

    void Delete(Guid id);
}

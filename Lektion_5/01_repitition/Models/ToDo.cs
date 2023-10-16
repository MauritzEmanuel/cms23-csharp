namespace _01_repitition.Models;

internal class ToDo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Activity { get; set; } = null!;
    public DateTime Created { get ; set; }  = DateTime.Now;
}

namespace ef_tasks.Models;

public class Task
{
    public Guid TaskId { get; set; }
    public Guid CategoryId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Priority TaskPriority { get; set; }
    public DateTime DateCreated { get; set; }

    public virtual Category Category { get; set; }
}

public enum Priority
{
    Baja,
    Media,
    Alta
}
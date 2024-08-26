using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef_tasks.Models;

public class Task
{
    [Key]
    public Guid TaskId { get; set; }

    [ForeignKey("CategoryId")]
    public Guid CategoryId { get; set; }

    [Required]
    [MaxLength(150)]
    [MinLength(3)]
    public string? Title { get; set; }

    [MinLength(3)]
    public string? Description { get; set; }
    public Priority TaskPriority { get; set; }
    public DateTime DateCreated { get; set; }

    public virtual Category? Category { get; set; }

    [NotMapped]
    public string? Resumen {get; set;}
}

public enum Priority
{
    Baja,
    Media,
    Alta
}
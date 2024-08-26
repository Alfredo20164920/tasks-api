using ef_tasks.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_tasks.Context;


public class TasksContext : DbContext {
    public DbSet<Models.Task> Tasks {get; set;}
    public DbSet<Category> Categories {get; set;}
    public TasksContext(DbContextOptions<TasksContext> options) : base(options) {}

}
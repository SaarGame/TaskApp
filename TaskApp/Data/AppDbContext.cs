using Microsoft.EntityFrameworkCore;

namespace TaskApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<TodoTask> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoTask>().HasData(
            new TodoTask
            {
                Id = 1,
                Title = "Buy groceries",
                Description = "Bread, Butter, Sugar, Carrots",
                Priority = 3,
                Category = Category.קניות,
                Location = Location.כללי,
                CreatedAt = DateTime.UtcNow.AddDays(-1),
                IsDone = false
            },
            new TodoTask
            {
                Id = 2,
                Title = "Clean Cat Shit",
                Description = "Clean the cat's litter box and surrounding area",
                Priority = 5,
                Category = Category.ניקיון,
                Location = Location.מטבחון,
                CreatedAt = DateTime.UtcNow,
                IsDone = true
            },
            new TodoTask
            {
                Id = 3,
                Title = "Finish This Dammed Project",
                Description = "Why Did I even start this project in the first place? I have no idea what I'm doing",
                Priority = 5,
                Category = Category.כללי,
                Location = Location.כללי,
                CreatedAt = DateTime.UtcNow.AddDays(-10),
                IsDone = false
            }
        );
    }
}

using Microsoft.EntityFrameworkCore;
using TodoListApp.Models;

namespace TodoListApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}

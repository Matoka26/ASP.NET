using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class DatabaseContext: DbContext
{
    public DbSet<Test> Tests { get; set; }
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
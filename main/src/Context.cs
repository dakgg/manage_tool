using Microsoft.EntityFrameworkCore;

public class BloggingContext : DbContext
{
    public DbSet<dakg.GameEvent> Events { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        DbPath = System.IO.Path.Join(Directory.GetCurrentDirectory(), "../main", "DbFile", "local.db");
        Console.WriteLine(DbPath);
    }

    public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
    {
        DbPath = System.IO.Path.Join(Directory.GetCurrentDirectory(), "../main", "DbFile", "local.db");
        Console.WriteLine(DbPath);
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
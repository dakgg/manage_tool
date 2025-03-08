using Microsoft.EntityFrameworkCore;

public class CommonContext : DbContext
{
    public DbSet<dakg.GameEvent> Events { get; set; }
    public DbSet<dakg.User> Users { get; set; }
    public string DbPath { get; }

    public CommonContext()
    {
        DbPath = System.IO.Path.Join(Directory.GetCurrentDirectory(), "../main", "DbFile", "local.db");
        Console.WriteLine(DbPath);
    }

    public CommonContext(DbContextOptions<CommonContext> options) : base(options)
    {
        DbPath = System.IO.Path.Join(Directory.GetCurrentDirectory(), "../main", "DbFile", "local.db");
        Console.WriteLine(DbPath);
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
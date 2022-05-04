using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SchoolApp.WebApi.Models;

namespace SchoolApp.WebApi.Configurations;

public class SchoolAppContext:DbContext
{
    public SchoolAppContext(DbContextOptions<SchoolAppContext>options):base(options)
    {
        Database.EnsureCreated();
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     base.OnConfiguring(optionsBuilder);
    //     const string connectionString = "Data Source=app.db";
    //     optionsBuilder.UseSqlite(connectionString);
    // }
    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SchoolAppContext).Assembly);
    }
    // public override void (ApplicationBuilder optionBuilder)
    // {
    // }

}
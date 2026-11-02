using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistance;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public required DbSet<Activity> Activities { get; set; }

}
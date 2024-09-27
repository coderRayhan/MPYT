using Microsoft.EntityFrameworkCore;
using MPYT.Entities;

namespace MPYT.DB;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<OrderReport> OrderReports { get; set; }
}
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    //Derive from a class
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
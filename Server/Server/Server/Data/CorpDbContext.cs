using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class CorpDbContext : DbContext
    {
        public CorpDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using PruebaCFA.Models;

namespace PruebaCFA.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}

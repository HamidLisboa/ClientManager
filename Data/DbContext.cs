using Microsoft.EntityFrameworkCore;
using ClientManager.Models;
namespace ClientManager.Data
{
    public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }
        public DbSet<Models.Client> Clients { get; set; }
    }
}

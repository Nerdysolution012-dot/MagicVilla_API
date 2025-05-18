using MagicVilla_API.DataEntity;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Villa> Villas { get; set; }
    }
}

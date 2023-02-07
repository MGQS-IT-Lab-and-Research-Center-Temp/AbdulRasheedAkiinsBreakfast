using AkiinsBreakfast.Entities;
using Microsoft.EntityFrameworkCore;

namespace AkiinsBreakfast.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Breakfast> Breakfasts { get; set; }
    }
}

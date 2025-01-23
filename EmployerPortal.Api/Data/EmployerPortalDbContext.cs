using EmployerPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployerPortal.Data
{
    public class EmployerPortalDbContext: DbContext
    {
        public EmployerPortalDbContext(DbContextOptions<EmployerPortalDbContext> options): base(options) { }
        public DbSet<User> Users { get; set; }
    }
}

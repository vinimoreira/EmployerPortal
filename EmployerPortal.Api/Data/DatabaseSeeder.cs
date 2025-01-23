using EmployerPortal.Models;
using System;

namespace EmployerPortal.Data
{
    public class DatabaseSeeder
    {
        private readonly EmployerPortalDbContext _dbContext;

        public DatabaseSeeder(EmployerPortalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (!_dbContext.Users.Any())
            {
                _dbContext.Users.AddRange(
                    new User { Id = 1, Username = "test", Name = "Test User" },
                    new User { Id = 2, Username = "vinicius", Name = "Vinicius Moreira" }
                );

                _dbContext.SaveChanges();
            }
        }
    }
}

using AuthAppV2.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthAppV2.Context
{
    public class AuthAppDbContext : DbContext
    {

        public AuthAppDbContext(DbContextOptions<AuthAppDbContext> options) : base (options)
        {
            
        }


        public DbSet<UserEntity> Users { get; set; }

    }
}

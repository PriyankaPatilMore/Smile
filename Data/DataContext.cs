using Microsoft.EntityFrameworkCore;
using Smile.API.Models;

namespace Smile.API.Data
{
    public class DataContext : DbContext
    {
   
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }
        
    }
}
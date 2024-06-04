using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;

namespace ApiDB.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
    }
}

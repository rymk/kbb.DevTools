using Kbb.DevTools.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kbb.DevTools.DAL
{
    public class DevToolsContext : DbContext
    {
        public DevToolsContext()
        {

        }

        public DevToolsContext(DbContextOptions<DevToolsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // TODO: move to config
                // TODO: user from somewhere or continue running under AppPool?
                // at time of DBMS installation connStr outputted was 
                //         "Server=localhost;Database=master;Trusted_Connection=True;"
                
                // TODO: will this work: "Server=localhost;Database=DevTools;Trusted_Connection=True;User Id=test;Password=test;"
                optionsBuilder.UseSqlServer(
                    @"Data Source=localhost;Initial Catalog=DevTools;Integrated Security=True;MultipleActiveResultSets=True");
            }
        }

        public DbSet<Return> Returns { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}

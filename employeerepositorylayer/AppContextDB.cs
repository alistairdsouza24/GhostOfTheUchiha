using Microsoft.EntityFrameworkCore;
using Modellayer;
using ModeLlayer;

namespace employeerepositorylayer
{
    public class AppContextDB:DbContext
    {
        public AppContextDB(DbContextOptions<AppContextDB> options)
        : base(options)
        {
        }
        public DbSet<Adduserdetails> Employee { get; set; }
        public DbSet<Designation> Employees { get; set; }

        public DbSet<LoginVerify> Login { get; set; }
    }
}
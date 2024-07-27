using Microsoft.EntityFrameworkCore;

namespace ChainOfRespProject.DAL
{
    public class Context:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6JTJ49H; initial Catalog=DbChain1; integrated security=true");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }

    }
}

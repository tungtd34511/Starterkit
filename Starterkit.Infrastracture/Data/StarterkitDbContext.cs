using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Starterkit.Infrastracture.Data.IdentityModel;

namespace Starterkit.Infrastracture.Data
{
    public class StarterkitDbContext : IdentityDbContext<User, Role, int>
    {
        public StarterkitDbContext()
        {
            
        }

        public StarterkitDbContext(DbContextOptions options): base(options)
        {
             
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=T1CON;Initial Catalog=Starterkit;Integrated Security=True;Trust Server Certificate=True");
            }
        }
    }
}

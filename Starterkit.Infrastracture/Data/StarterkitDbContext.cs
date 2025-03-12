using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Starterkit.Infrastracture.Data
{
    public class StarterkitDbContext : DbContext
    {
        public StarterkitDbContext()
        {
            
        }

        public StarterkitDbContext(DbContextOptions options): base(options)
        {
             
        }
    }
}

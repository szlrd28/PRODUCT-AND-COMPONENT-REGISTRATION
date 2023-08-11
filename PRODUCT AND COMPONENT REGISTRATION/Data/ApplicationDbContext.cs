using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Keszprojekt.Models;

namespace Keszprojekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

  
        
            
        }

        public DbSet<Keszprojekt.Models.Alkatreszek> Alkatreszek { get; set; }
        public DbSet<Keszprojekt.Models.Termekek> Termekek { get; set; }
         


    }
}

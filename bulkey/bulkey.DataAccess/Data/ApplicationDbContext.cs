using bulkey.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bulkey.DataAccess
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)

        {

        }
        public DbSet<CategoryRepositery>Categories { get; set; } 
        public DbSet<CoverType>coverTypes { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        public DbSet<Compan> newComp { get; set; }
        //public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}

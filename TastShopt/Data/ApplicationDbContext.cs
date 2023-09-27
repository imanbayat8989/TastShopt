using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TastShopt.Models;

namespace TastShopt.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Royal",
                    Details = "Some dummy text",
                    ImageUrl = "https://www.raffles.com/assets/0/72/2764/2765/2786/6c64d74a-f58d-4de2-a61e-8666413a354c.jpg",
                    Rate = 200,
                    CreateDate = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    Name = "Swimpoll",
                    Details = "Some dummy text",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/301483778.jpg?k=b1f449beb857de98e8287c34956b672956926c2d03ac185ff8d9a348622c157a&o=&hp=1",
                    Rate = 200,
                    CreateDate = DateTime.Now,
                },
                new Product
                {
                    Id = 3,
                    Name = "partyVilla",
                    Details = "Some dummy text",
                    ImageUrl = "https://media.vrbo.com/lodging/30000000/29490000/29484300/29484212/b479b134.c10.jpg",
                    Rate = 200,
                    CreateDate = DateTime.Now,
                }
                );
        }
    }
}

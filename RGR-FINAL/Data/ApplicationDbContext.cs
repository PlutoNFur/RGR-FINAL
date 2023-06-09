using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RGR_FINAL.Data.Identity;
using static System.Net.WebRequestMethods;

namespace RGR_FINAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Lot>().Property(z  => z.Id).UseIdentityColumn();
            builder.Entity<Lot>().Property(z => z.Name).HasMaxLength(20);
            builder.Entity<Lot>().HasData(
                new Lot
                {
                    Id = 1,
                    Name = "Picture",
                    Description = "A picture with a lot of meaning",
                    StartPrice = 10000,
                    EndTime = DateTime.Now.AddHours(5),
                    Category = Categories.art,
                    Img = "https://crosti.ru/patterns/00/0a/3e/f7_picture_0b6d313d.jpg",
                    Expired = false,
                    StartDate = DateTime.Now,
                });

            base.OnModelCreating(builder);
        }
        public DbSet<Lot> Lots { get; set; }
    }
}
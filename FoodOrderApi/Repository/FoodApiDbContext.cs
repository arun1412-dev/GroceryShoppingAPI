using FoodOrderApi.Model;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderApi.Repository
{
    public class FoodApiDbContext : DbContext
    {
        public FoodApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
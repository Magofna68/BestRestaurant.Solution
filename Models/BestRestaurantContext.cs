using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
  public class BestRestaurantContext : DbContext
  {

    public virtual DbSet<Cuisine> Cuisine { get; set; }
    public DbSet<Restaurant> Restaurant { get; set; }

    public BestRestaurantContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
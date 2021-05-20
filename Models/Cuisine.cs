using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurant = new HashSet<Restaurant>();
    }

    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Restaurant { get; set; }
  }
}
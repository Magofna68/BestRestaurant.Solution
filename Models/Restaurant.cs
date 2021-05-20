using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public string Name { get; set; }
    public int RestaurantId { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}
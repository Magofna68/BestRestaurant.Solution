using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BestRestaurant.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly BestRestaurantContext _db;

    public RestaurantsController(BestRestaurantContext db)
    {
      _db = db;
    }
    public ActionResult Delete(int id)
    {
      var thisRestaurant = _db.Restaurant.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisRestaurant = _db.Restaurant.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      _db.Restaurant.Remove(thisRestaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Restaurant thisRestaurant = _db.Restaurant.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
    }
  }
}
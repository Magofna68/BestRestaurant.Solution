public ActionResult Create()
{
  return View();
}

[HttpPost]
public ActionResult Create(Cuisine cuisine)
{
  _db.Cuisine.Add(cuisine);
  _db.SaveChanges();
  return RedirectToAction("Index");
}

 public ActionResult Delete(int id)
    {
      var thisCuisine = _db.Cuisine.FirstOrDefault(restaurant => restaurant.CuisineId == id);
      return View(thisCuisine);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCuisine = _db.Restaurant.FirstOrDefault(cuisine => cuisine.CuisineId == id);
      _db.Cuisine.Remove(thisCuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
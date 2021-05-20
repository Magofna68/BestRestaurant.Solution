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
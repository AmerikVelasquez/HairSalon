using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers 
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContex db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> stylist = _db.Stylists.ToList();
      return View(stylist);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
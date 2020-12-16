using Microsoft.AspNetCore.Mvc;
using TamaTucci.Models;
using System.Collections.Generic;

namespace TamaTucci.Controllers
{
  public class TamatuccisController : Controller
  {
    [HttpGet("/tamatuccis")]
    public ActionResult Index()
    {
      List<Tucci> allTuccis = Tucci.GetAll();
      return View(allTuccis);
    }
    [HttpGet("/tamatuccis/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/tamatuccis")]
    public ActionResult Create(string tucciName)
    {
      Tucci myTucci = new Tucci(tucciName);
      return RedirectToAction("Index");
    }

    [HttpPost("/tamatuccis/delete")]
    public ActionResult Delete()
    {
      Tucci.ClearAll();
      return View();
    }

    [HttpGet("/tamatuccis/{id}")]
    public ActionResult Show(int id)
    {
      Tucci foundTucci = Tucci.Find(id);
      return View(foundTucci);
    }
  }
}
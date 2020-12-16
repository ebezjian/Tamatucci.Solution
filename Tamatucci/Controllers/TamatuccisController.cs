using Microsoft.AspNetCore.Mvc;
using TamaTucci.Models;
using System.Collections.Generic;

namespace TamaTucci.Controllers
{
  public class TuccisController : Controller
  {
    [HttpGet("/tamatuccis")]
    public ActionResult Index()
    {
      List<Tucci> allTuccis = Tucci.GetAll();
      return View(allTuccis);
    }
  }
}
using Microsoft.AspNetCore.Mvc;

namespace TamaTucci.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}
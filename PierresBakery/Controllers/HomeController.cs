using Microsoft.Aspusing Microsoft.AspNetCore.Mvc;

namespace PierresBakery.Controller
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
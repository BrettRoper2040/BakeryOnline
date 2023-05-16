using Microsoft.AspNetCore.Mvc;

namespace BakeOnline.Controllers
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
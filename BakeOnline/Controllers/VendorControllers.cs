using Microsoft.AspNetCore.Mvc;
using BakeOnline.Models;
using System.Collections.Generic;

namespace BakeOnline.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/Vendors")]
    public ActionResult Index()
    {
      List<Vendors> allItems = Vendors.GetAll();
      return View(allItems);
    }
  }
}
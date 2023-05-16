using Microsoft.AspNetCore.Mvc;
using TwoDoList.Models;
using System.Collections.Generic;

namespace BakeOnline.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/Vendors")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }
  }
}
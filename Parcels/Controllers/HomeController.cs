using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/form")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cost")]
    public ActionResult Cost()
    {
      Parcel myParcels = new Parcel(Request.Form["height"],Request.Form["length"],Request.Form["width"],Request.Form["weight"]);
      return View(myParcels);
    }

  }
}

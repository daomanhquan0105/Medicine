using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShipMedicineFast.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult CartInformation()
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }
    }
}
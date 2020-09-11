using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShipMedicineFast.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListProduct()
        {
            return View();
        }

        public ActionResult ProductDetail()
        {
            return View();
        }
          

        #region PartialView
        [ChildActionOnly]
        public PartialViewResult HeaderPartialView()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult FooterPartialView()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult MenuMobile()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult SliderPartialView()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public PartialViewResult SliderTabPartialView()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public PartialViewResult BannerProduct()
        {
            return PartialView();
        }
        #endregion
    }
}
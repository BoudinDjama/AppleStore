using Appstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Appstore.Controllers
{
    public class AppStoreController : Controller
    {
        // GET: Apps
        public ActionResult Search()
        {
            return View();
        }
        public ActionResult Games()
        {
           
            return View();
        }
        public ActionResult Apps()
        {
            return View();
        }
        public ActionResult Today()
        {
            return View();
        }
        public ActionResult Category()
        {
            return Content("this will be the category pages");
        }
    }
}
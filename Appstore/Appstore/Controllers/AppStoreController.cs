
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Appstore.DataSqlite;

namespace Appstore.Controllers
{
    public class AppStoreController : Controller
    {

        AppstoreContext db = new AppstoreContext();
        // GET: Apps
        public ActionResult Search()
        {
            var  test = db.Devs.ToList() ;
            return View();
        }
        public ActionResult Games()
        {
            var test = db.Devs.ToList();

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
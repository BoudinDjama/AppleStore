
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
            return View();
        }
        public ActionResult Publishers()
        {
            var publishers = db.Devs.ToList();
            return View("Publishers",publishers);
        }

        [HttpPost]
        public ViewResult Publishers(string filter)
        {
            filter.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(filter))
            {
                return View(db.Devs.ToList());
            }
            var publishers = db.Devs.Where(x =>
            x.Name.ToLower().Contains(filter) ||
            x.Description.ToLower().Contains(filter) ||
            x.Email.ToLower().Contains(filter)).ToList();
            return View(publishers);
        }
    }
}
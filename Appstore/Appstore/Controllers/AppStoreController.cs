
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
       
        public ActionResult Apps()
        {
            var app = db.Apps.ToList().OrderBy(x=>x.Name);
            return View("Apps", app);
        }
        public ActionResult Today()
        {
            var app = db.Apps.ToList().OrderByDescending(x => x.PublishDate).Select(x=>x).Take(4);

            return View("Today",app);
        }
        public ActionResult Category()
        {
            var categories = db.Categories.ToList();
            return View("Category", categories);
        }
        public ActionResult CategoryView()
        {
           
            var categories = db.Categories.ToList().OrderBy(x=>x.Name);
            return View("CategoryView", categories);
           
        }
        
        public ActionResult Publishers()
        {
            var publishers = db.Devs.ToList();
            return View("Publishers",publishers);
        }

        [HttpPost]
        public ViewResult Publishers(string filter)
        {

            if (string.IsNullOrWhiteSpace(filter))
            {
                return View(db.Devs.ToList());
            }
            filter.ToLower().Trim();

            var publishers = db.Devs.Where(x =>
            x.Name.ToLower().Contains(filter) ||
            x.Description.ToLower().Contains(filter) ||
            x.Email.ToLower().Contains(filter)).ToList();
            return View(publishers);
        }
        [HttpPost]
        public ViewResult CategoryView(string filter)
        {

            if (string.IsNullOrWhiteSpace(filter))
            {
                return View(db.Categories.ToList());
            }
            filter.ToLower().Trim();

            var categories = db.Categories.Where(x =>
            x.Name.ToLower().Contains(filter) ||
            x.Description.ToLower().Contains(filter)).ToList();
            return View(categories);
        }

        [HttpPost]
        public ViewResult Apps(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                return View(db.Apps.ToList());
            }
            filter.ToLower().Trim();

       
            var apps = db.Apps.Where(x =>
            x.Name.ToLower().Contains(filter) ||
            x.Description.ToLower().Contains(filter)).ToList();
            return View(apps);
        }
    }
}
﻿
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
            var app = db.Apps.ToList();
            return View("Apps", app);
        }
        public ActionResult Today()
        {
            var app = db.Apps.ToList().OrderByDescending(x => x.PublishDate).Select(x=>x).Take(4);

            return View("Today",app);
        }
        public ActionResult Category()
        {
            return View();
        }
        public ActionResult CategoryView()
        {
            // var categories = db.Apps.Where(x => x.Category.Name == category).ToList();
            //var categories = db.Apps.Where(x => x.Category.Name == "Games").ToList();
            var categories = db.Categories.ToList();
            return View("CategoryView", categories);
           
        }
        public ActionResult AllApps()
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
        public ViewResult Categories(string filter)
        {
            filter.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(filter))
            {
                return View(db.Categories.ToList());
            }
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
                return View(db.Devs.ToList());
            }
            filter.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(filter))
            {
                return View(db.Apps.ToList());
            }
            var apps = db.Apps.Where(x =>
            x.Name.ToLower().Contains(filter) ||
            x.Description.ToLower().Contains(filter)).ToList();
            return View(apps);
        }
    }
}
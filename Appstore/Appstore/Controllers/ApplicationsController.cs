using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Appstore.Controllers
{
    public class ApplicationsController : Controller
    {
        AppstoreContext db = new AppstoreContext();

        // GET: Applications
        public ActionResult NewApp()
        {
            return View();
        }
       
        
    }
}
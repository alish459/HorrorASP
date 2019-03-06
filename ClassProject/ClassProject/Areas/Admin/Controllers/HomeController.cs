using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassProject.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }
        public ActionResult TableList()
        {
            return View();
        }
        public ActionResult Typography()
        {
            return View();
        }
        public ActionResult Icons()
        {
            return View();
        }
        public ActionResult Maps()
        {
            return View();
        }
        public ActionResult Notifications()
        {
            return View();
        }
        public ActionResult Upgrade()
        {
            return View();
        }
    }
}
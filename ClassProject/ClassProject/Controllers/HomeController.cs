using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(model: (List<MVC.Connecntion.Table.AllText>)(new MVC.Connecntion.CrudService.AllTextService().Read()));
        }
        [Route("منوي-ما")]
        public ActionResult OurMenus()
        {
            return View();
        }
        [Route("اخبار")]
        public ActionResult Blog()
        {
            return View();
        }
        [Route("تماس")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}
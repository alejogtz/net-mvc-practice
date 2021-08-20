using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_practice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // ActionName = Index
        public ActionResult Index()
        {
            // Inferred
            // View that matches with `Action` name ~/Views/{Controller}/{ActionName}
            return View();
        }


        public ActionResult About()
        {
            // Overwrites default view location name by custom view location name;
            return View();
        }

        public ActionResult Contact()
        {
            // Overwrites default view location name by custom view location name;
            return View("~/Views/Home/FakeContact.cshtml");
        }

        //public ActionResult Description()
        //{
        //    // Overwrites default view location name by custom view location name;
        //    return Json(new { mensaje = $"{Request.QueryString}" });
        //}

        [HttpGet]
        public JsonResult Description(string name)
        {
            // Overwrites default view location name by custom view location name;
            return Json(new
            {
                Nombre = $"¡Hola {name}!",
                mensaje = $"{Request.QueryString}"
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
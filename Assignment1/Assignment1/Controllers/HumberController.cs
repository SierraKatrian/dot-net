using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class HumberController : Controller
    {
        // GET: Humber
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Students()
        {
            Students sierra = new Students();
            sierra.Name = "Sierra Katrian";
            sierra.StudentNum = "N01169395";
            sierra.Program = "Web Developement";

            return View(sierra);
        }
    }
}
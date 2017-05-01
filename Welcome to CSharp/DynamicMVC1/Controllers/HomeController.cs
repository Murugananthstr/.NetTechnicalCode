using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicMVC1.Models;

namespace DynamicMVC1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CustomActionResult()
        {
            var appVar = new List<DynamicMVC1.Models.Employee>();

            appVar.Add(new Employee(1, "Ananth", "Dep1"));
            appVar.Add(new Employee(2, "Ananth2", "Dep2"));

            //appVar.Add(new Employee ( EmpId = 2, EmpName = Mohan", DepName = "Dep2"));

            return new XMLResult(appVar);
        }
    }
}
using aspDatabase.Models.Database;
using aspDatabase.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspDatabase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //written part
            UMS_S_AEntities db = new UMS_S_AEntities();
            var dept = (from d in db.Departments where d.id == 1 select d).FirstOrDefault();
            DepartmentModel D = new DepartmentModel();
            D.Name = dept.Name;
            D.id = dept.id;
            //edit end
            return View(dept);
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
    }
}
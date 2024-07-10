using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_PJ_08032020.Models;

namespace MVC_PJ_08032020.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home  
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("Index");
            }

            return View();
        }
    }
}
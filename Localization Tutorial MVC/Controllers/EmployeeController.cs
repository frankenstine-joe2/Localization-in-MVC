using Localization_Tutorial_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Localization_Tutorial_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> Employees = new List<Employee>();

        // GET: Employee
        public ActionResult Index()
        {
            return View(Employees);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}

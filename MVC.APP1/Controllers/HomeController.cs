using MVC.APP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary1.BusinessLogic.EmployeeProccessor;

namespace MVC.APP1.Controllers
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
        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employees List.";
            var data = LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach(var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    EmployeeId = row.Employeeid,
                    Name = row.Name

                });
            }
            return View(employees);
        }


        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee SignUp";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int recordCreatead = CreateEmployee(model.EmployeeId, model.Name);
                return RedirectToAction("Index");
            }
            

            return View();
        }
    }
}
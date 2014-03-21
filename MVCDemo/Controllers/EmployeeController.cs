using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Detail(int id)
        {
            EmployeeContext empContext = new EmployeeContext();
            Employee employee = empContext.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObjects;
using ServiceLayer;

namespace RMS.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(BusinessObjects.Employee objmodelemp)
        {
            ServiceLayer.Employee objsaemp = new ServiceLayer.Employee();
            int i = objsaemp.AddEmp(objmodelemp);
            if (i == 1)
            {
                return RedirectToAction("Index","Employee");
            }
            else
            {
                return View();
            }
        }

        public List<BusinessObjects.Employee> GetEmp()//this method will return one collection
        {
            ServiceLayer.Employee objsaemp = new ServiceLayer.Employee();
            var employees = objsaemp.GetEmp();
            return employees;

        }
    }
}
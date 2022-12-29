using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObjects;

namespace RMS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Aboutus()
        {
            return View();
        }
        public ActionResult Contactus()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(BusinessObjects.Login l)
        {
            if (l.UserName=="Admin" && l.Password=="Admin")
            {
                return RedirectToAction("AdminHome");
            }
            else if (l.UserName=="Floor" &&  l.Password=="Floor")
            {
                return RedirectToAction("FloorHome");
            }
            else if (l.UserName=="Kitchen" && l.Password=="Kitchen")
            {
                return RedirectToAction("KitchHome");
            }
            else if (l.UserName=="Manager" && l.Password=="Manager")
            {
                return RedirectToAction("ManagerHome");
            }
            return View();
        }
        public ActionResult AdminHome()
        {
            return View();
        }
        public ActionResult FloorHome()
        {
            return View();
        }
        public ActionResult KitchHome()
        {
            return View();
        }
    }
}
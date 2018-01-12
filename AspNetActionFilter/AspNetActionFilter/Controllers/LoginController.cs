using AspNetActionFilter.Filters;
using AspNetActionFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetActionFilter.Controllers
{
    public class LoginController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Login
        public ActionResult SignIn()
        {
            Test test = new Test();
            return View(new User());
        }
        //Just this Method
        
        [HttpPost]
        public ActionResult SignIn(User data)
        {
            User user = db.User.FirstOrDefault(x => x.UserName == data.UserName && x.Password == data.Password);

            if (user != null)
            {
                Session["User"] = user;

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}
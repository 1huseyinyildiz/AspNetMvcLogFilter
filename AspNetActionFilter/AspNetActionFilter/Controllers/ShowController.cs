using AspNetActionFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetActionFilter.Controllers
{
    public class ShowController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Show
        public ActionResult Index()
        {
            return View(db.Logs.ToList());
        }
    }
}
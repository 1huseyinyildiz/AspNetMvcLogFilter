using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetActionFilter.Filters;
namespace AspNetActionFilter.Controllers
{
    //All Controller Filter
    [ActFilter, AuthFilter, RestFilter]
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            //insert to Table in Database.. Start

            //Cods


            //Logs Table instert to Action_end

            return View();
        }

        public ActionResult About()
        {
            //insert to Table in Database.. Start

            //Cods


            //Logs Table instert to Action_end


            return View();
        }
        public ActionResult Contact()
        {
            //insert to Table in Database.. Start

            //Cods


            //Logs Table instert to Action_end


            return View();
        }
    }
}
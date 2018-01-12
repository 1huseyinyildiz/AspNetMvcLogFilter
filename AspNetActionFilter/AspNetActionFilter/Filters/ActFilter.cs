using AspNetActionFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetActionFilter.Filters
{
    public class ActFilter : FilterAttribute , IActionFilter
    {
        DatabaseContext db = new DatabaseContext();
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            db.Logs.Add(new Log()
            {
                UserName =(filterContext.HttpContext.Session["User"] as User).Name,
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                DataTime = DateTime.Now,
                information = "OnActionExecuted",

            });
            db.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            db.Logs.Add(new Log()
            {
                UserName = (filterContext.HttpContext.Session["User"] as User).Name,
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                DataTime =DateTime.Now,
                information= "OnActionExecuting",

            });
            db.SaveChanges();

        }
    }
}
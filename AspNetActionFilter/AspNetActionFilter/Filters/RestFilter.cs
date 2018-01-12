using AspNetActionFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetActionFilter.Filters
{
    public class RestFilter : FilterAttribute, IResultFilter
    {
        DatabaseContext db = new DatabaseContext();
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            db.Logs.Add(new Log()
            {
                UserName = (filterContext.HttpContext.Session["User"] as User).Name,
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                DataTime = DateTime.Now,
                information = "OnResultExecuted",

            });
            db.SaveChanges();
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            db.Logs.Add(new Log()
            {
                UserName = (filterContext.HttpContext.Session["User"] as User).Name,
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                DataTime = DateTime.Now,
                information = "OnResultExecuting",

            });
            db.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.WebApi
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("/Swagger/ui/index");
        }
    }
}
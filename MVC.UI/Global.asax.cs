using Infrastructure;
using MVC.App;
using MVC.UI.App_Start;
using MVC.UI.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutofacExt.InitAutofac();//注入
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            ModelBinders.Binders.Add(typeof(JObject), new JobjectModelBinder());
            LogHelper.Log("启动Web");
        }
    }
}

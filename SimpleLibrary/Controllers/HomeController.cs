using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleLibrary.DataModel.BaseContext;
using WebGrease.Css;

namespace SimpleLibrary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        }
}
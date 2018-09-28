using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;
using SimpleLibrary.DataModel;
using SimpleLibrary.DataModel.DataProviders;

namespace SimpleLibrary.Controllers
{
    public class LibraryController : Controller
    {
        public ActionResult Library(int isAvailable = -1)
        {
            return View("Library", LibraryDataProvider.Instance.getBooks(isAvailable));
        }

        public ActionResult borrowBook(int id, int isAvailable = -1)
        {
            LibraryDataProvider.Instance.borrowBook(id);
            return new RedirectToRouteResult(new RouteValueDictionary(
                new { action = "Library", controller = "Library", isAvailable }));
        }
    }
}

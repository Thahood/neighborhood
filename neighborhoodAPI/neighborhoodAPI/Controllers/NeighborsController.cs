using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace neighborhoodAPI.Controllers
{
    public class NeighborsController : Controller
    {
        //
        // GET: /Neighbors/
        public ActionResult Index()
        {
            return View();
        }
	}
}
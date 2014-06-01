using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace neighborhoodAPI.Controllers
{
    public class NeighborhoodsController : Controller
    {
        //
        // GET: /Neighborhoods/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alerts()
        {
            return View();
        }
	}
}
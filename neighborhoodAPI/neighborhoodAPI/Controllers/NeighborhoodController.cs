using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace neighborhoodAPI.Controllers
{
    public class NeighborhoodController : Controller
    {
        //
        // GET: /Neighborhoods/
        public ActionResult Index()
        {
            return View();
        }
	}
}
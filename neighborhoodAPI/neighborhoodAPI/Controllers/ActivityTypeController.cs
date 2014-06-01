using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using neighborhoodAPI.Models;

namespace neighborhoodAPI.Controllers
{
    public class ActivityTypeController : Controller
    {
        private NeighborhoodDbContext db = new NeighborhoodDbContext();

        // GET: /ActivityType/
        public ActionResult Index()
        {
            return View(db.ActivityTypes.ToList());
        }

        // GET: /ActivityType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityType activitytype = db.ActivityTypes.Find(id);
            if (activitytype == null)
            {
                return HttpNotFound();
            }
            return View(activitytype);
        }

        // GET: /ActivityType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ActivityType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name")] ActivityType activitytype)
        {
            if (ModelState.IsValid)
            {
                db.ActivityTypes.Add(activitytype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(activitytype);
        }

        // GET: /ActivityType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityType activitytype = db.ActivityTypes.Find(id);
            if (activitytype == null)
            {
                return HttpNotFound();
            }
            return View(activitytype);
        }

        // POST: /ActivityType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name")] ActivityType activitytype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activitytype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activitytype);
        }

        // GET: /ActivityType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityType activitytype = db.ActivityTypes.Find(id);
            if (activitytype == null)
            {
                return HttpNotFound();
            }
            return View(activitytype);
        }

        // POST: /ActivityType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActivityType activitytype = db.ActivityTypes.Find(id);
            db.ActivityTypes.Remove(activitytype);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

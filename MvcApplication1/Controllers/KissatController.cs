using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class KissatController : Controller
    {
        private KissaDBContext db = new KissaDBContext();

        //
        // GET: /Kissat/

        public ActionResult Index()
        {
            return View(db.Kissat.ToList());
        }

        //
        // GET: /Kissat/Details/5

        public ActionResult Details(int id = 0)
        {
            Kissa kissa = db.Kissat.Find(id);
            if (kissa == null)
            {
                return HttpNotFound();
            }
            return View(kissa);
        }

        //
        // GET: /Kissat/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Kissat/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Kissa kissa)
        {
            if (ModelState.IsValid)
            {
                db.Kissat.Add(kissa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kissa);
        }

        //
        // GET: /Kissat/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Kissa kissa = db.Kissat.Find(id);
            if (kissa == null)
            {
                return HttpNotFound();
            }
            return View(kissa);
        }

        //
        // POST: /Kissat/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Kissa kissa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kissa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kissa);
        }

        //
        // GET: /Kissat/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Kissa kissa = db.Kissat.Find(id);
            if (kissa == null)
            {
                return HttpNotFound();
            }
            return View(kissa);
        }

        //
        // POST: /Kissat/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kissa kissa = db.Kissat.Find(id);
            db.Kissat.Remove(kissa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
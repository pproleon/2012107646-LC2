using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2012107646_ENT;
using _2012107646_PER;

namespace _2012107646_MVC.Controllers
{
    public class TipoPlansController : Controller
    {
        private PaulDbContext db = new PaulDbContext();

        // GET: TipoPlans
        public ActionResult Index()
        {
            return View(db.TipoPlan.ToList());
        }

        // GET: TipoPlans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPlan tipoPlan = db.TipoPlan.Find(id);
            if (tipoPlan == null)
            {
                return HttpNotFound();
            }
            return View(tipoPlan);
        }

        // GET: TipoPlans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoPlans/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoPlanID")] TipoPlan tipoPlan)
        {
            if (ModelState.IsValid)
            {
                db.TipoPlan.Add(tipoPlan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoPlan);
        }

        // GET: TipoPlans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPlan tipoPlan = db.TipoPlan.Find(id);
            if (tipoPlan == null)
            {
                return HttpNotFound();
            }
            return View(tipoPlan);
        }

        // POST: TipoPlans/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoPlanID")] TipoPlan tipoPlan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoPlan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoPlan);
        }

        // GET: TipoPlans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPlan tipoPlan = db.TipoPlan.Find(id);
            if (tipoPlan == null)
            {
                return HttpNotFound();
            }
            return View(tipoPlan);
        }

        // POST: TipoPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoPlan tipoPlan = db.TipoPlan.Find(id);
            db.TipoPlan.Remove(tipoPlan);
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

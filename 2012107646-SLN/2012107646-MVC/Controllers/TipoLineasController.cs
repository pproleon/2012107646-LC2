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
    public class TipoLineasController : Controller
    {
        private PaulDbContext db = new PaulDbContext();

        // GET: TipoLineas
        public ActionResult Index()
        {
            return View(db.TipoLinea.ToList());
        }

        // GET: TipoLineas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLinea tipoLinea = db.TipoLinea.Find(id);
            if (tipoLinea == null)
            {
                return HttpNotFound();
            }
            return View(tipoLinea);
        }

        // GET: TipoLineas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoLineas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoLineaID,LineaTelefonicaID")] TipoLinea tipoLinea)
        {
            if (ModelState.IsValid)
            {
                db.TipoLinea.Add(tipoLinea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoLinea);
        }

        // GET: TipoLineas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLinea tipoLinea = db.TipoLinea.Find(id);
            if (tipoLinea == null)
            {
                return HttpNotFound();
            }
            return View(tipoLinea);
        }

        // POST: TipoLineas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoLineaID,LineaTelefonicaID")] TipoLinea tipoLinea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoLinea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoLinea);
        }

        // GET: TipoLineas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLinea tipoLinea = db.TipoLinea.Find(id);
            if (tipoLinea == null)
            {
                return HttpNotFound();
            }
            return View(tipoLinea);
        }

        // POST: TipoLineas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoLinea tipoLinea = db.TipoLinea.Find(id);
            db.TipoLinea.Remove(tipoLinea);
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

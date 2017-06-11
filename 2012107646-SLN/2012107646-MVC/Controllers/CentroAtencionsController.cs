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
    public class CentroAtencionsController : Controller
    {
        private PaulDbContext db = new PaulDbContext();

        // GET: CentroAtencions
        public ActionResult Index()
        {
            return View(db.CentroAtencion.ToList());
        }

        // GET: CentroAtencions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = db.CentroAtencion.Find(id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // GET: CentroAtencions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CentroAtencions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CentroAtencionID,DireccionID,EvaluacionID,VentaID")] CentroAtencion centroAtencion)
        {
            if (ModelState.IsValid)
            {
                db.CentroAtencion.Add(centroAtencion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(centroAtencion);
        }

        // GET: CentroAtencions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = db.CentroAtencion.Find(id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // POST: CentroAtencions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CentroAtencionID,DireccionID,EvaluacionID,VentaID")] CentroAtencion centroAtencion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(centroAtencion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(centroAtencion);
        }

        // GET: CentroAtencions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = db.CentroAtencion.Find(id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // POST: CentroAtencions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CentroAtencion centroAtencion = db.CentroAtencion.Find(id);
            db.CentroAtencion.Remove(centroAtencion);
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

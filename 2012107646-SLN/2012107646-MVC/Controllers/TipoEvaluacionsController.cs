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
    public class TipoEvaluacionsController : Controller
    {
        private PaulDbContext db = new PaulDbContext();

        // GET: TipoEvaluacions
        public ActionResult Index()
        {
            return View(db.TipoEvaluacion.ToList());
        }

        // GET: TipoEvaluacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEvaluacion tipoEvaluacion = db.TipoEvaluacion.Find(id);
            if (tipoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(tipoEvaluacion);
        }

        // GET: TipoEvaluacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEvaluacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoEvaluacionID,EvaluacionID")] TipoEvaluacion tipoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                db.TipoEvaluacion.Add(tipoEvaluacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoEvaluacion);
        }

        // GET: TipoEvaluacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEvaluacion tipoEvaluacion = db.TipoEvaluacion.Find(id);
            if (tipoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(tipoEvaluacion);
        }

        // POST: TipoEvaluacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoEvaluacionID,EvaluacionID")] TipoEvaluacion tipoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoEvaluacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoEvaluacion);
        }

        // GET: TipoEvaluacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEvaluacion tipoEvaluacion = db.TipoEvaluacion.Find(id);
            if (tipoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(tipoEvaluacion);
        }

        // POST: TipoEvaluacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoEvaluacion tipoEvaluacion = db.TipoEvaluacion.Find(id);
            db.TipoEvaluacion.Remove(tipoEvaluacion);
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

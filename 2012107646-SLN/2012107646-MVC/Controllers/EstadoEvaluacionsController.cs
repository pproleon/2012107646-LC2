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
    public class EstadoEvaluacionsController : Controller
    {
        private PaulDbContext db = new PaulDbContext();

        // GET: EstadoEvaluacions
        public ActionResult Index()
        {
            return View(db.EstadoEvaluacion.ToList());
        }

        // GET: EstadoEvaluacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(id);
            if (estadoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(estadoEvaluacion);
        }

        // GET: EstadoEvaluacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoEvaluacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstadoEvaluacionID,EvaluacionID")] EstadoEvaluacion estadoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                db.EstadoEvaluacion.Add(estadoEvaluacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadoEvaluacion);
        }

        // GET: EstadoEvaluacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(id);
            if (estadoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(estadoEvaluacion);
        }

        // POST: EstadoEvaluacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstadoEvaluacionID,EvaluacionID")] EstadoEvaluacion estadoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadoEvaluacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadoEvaluacion);
        }

        // GET: EstadoEvaluacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(id);
            if (estadoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(estadoEvaluacion);
        }

        // POST: EstadoEvaluacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(id);
            db.EstadoEvaluacion.Remove(estadoEvaluacion);
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

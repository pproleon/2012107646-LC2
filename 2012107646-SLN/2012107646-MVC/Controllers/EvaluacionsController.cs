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
    public class EvaluacionsController : Controller
    {
        private PaulDbContext db = new PaulDbContext();

        // GET: Evaluacions
        public ActionResult Index()
        {
            var evaluacion = db.Evaluacion.Include(e => e.CentroAtencion).Include(e => e.Trabajador).Include(e => e.Venta);
            return View(evaluacion.ToList());
        }

        // GET: Evaluacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = db.Evaluacion.Find(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // GET: Evaluacions/Create
        public ActionResult Create()
        {
            ViewBag.CentroAtencionID = new SelectList(db.CentroAtencion, "CentroAtencionID", "CentroAtencionID");
            ViewBag.TrabajadorID = new SelectList(db.Trabajador, "TrabajadorID", "TrabajadorID");
            ViewBag.EvaluacionID = new SelectList(db.Venta, "VentaID", "VentaID");
            return View();
        }

        // POST: Evaluacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EvaluacionID,VentaID,TrabajadorID,CentroAtencionID")] Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Evaluacion.Add(evaluacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CentroAtencionID = new SelectList(db.CentroAtencion, "CentroAtencionID", "CentroAtencionID", evaluacion.CentroAtencionID);
            ViewBag.TrabajadorID = new SelectList(db.Trabajador, "TrabajadorID", "TrabajadorID", evaluacion.TrabajadorID);
            ViewBag.EvaluacionID = new SelectList(db.Venta, "VentaID", "VentaID", evaluacion.EvaluacionID);
            return View(evaluacion);
        }

        // GET: Evaluacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = db.Evaluacion.Find(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.CentroAtencionID = new SelectList(db.CentroAtencion, "CentroAtencionID", "CentroAtencionID", evaluacion.CentroAtencionID);
            ViewBag.TrabajadorID = new SelectList(db.Trabajador, "TrabajadorID", "TrabajadorID", evaluacion.TrabajadorID);
            ViewBag.EvaluacionID = new SelectList(db.Venta, "VentaID", "VentaID", evaluacion.EvaluacionID);
            return View(evaluacion);
        }

        // POST: Evaluacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EvaluacionID,VentaID,TrabajadorID,CentroAtencionID")] Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evaluacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CentroAtencionID = new SelectList(db.CentroAtencion, "CentroAtencionID", "CentroAtencionID", evaluacion.CentroAtencionID);
            ViewBag.TrabajadorID = new SelectList(db.Trabajador, "TrabajadorID", "TrabajadorID", evaluacion.TrabajadorID);
            ViewBag.EvaluacionID = new SelectList(db.Venta, "VentaID", "VentaID", evaluacion.EvaluacionID);
            return View(evaluacion);
        }

        // GET: Evaluacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = db.Evaluacion.Find(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // POST: Evaluacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evaluacion evaluacion = db.Evaluacion.Find(id);
            db.Evaluacion.Remove(evaluacion);
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

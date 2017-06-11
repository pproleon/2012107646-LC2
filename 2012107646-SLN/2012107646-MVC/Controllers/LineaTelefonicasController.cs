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
    public class LineaTelefonicasController : Controller
    {
        private PaulDbContext db = new PaulDbContext();

        // GET: LineaTelefonicas
        public ActionResult Index()
        {
            var lineaTelefonica = db.LineaTelefonica.Include(l => l.AdministradorLinea).Include(l => l.Venta);
            return View(lineaTelefonica.ToList());
        }

        // GET: LineaTelefonicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // GET: LineaTelefonicas/Create
        public ActionResult Create()
        {
            ViewBag.AdministradorLineaID = new SelectList(db.AdministradorLinea, "AdministradorLineaID", "AdministradorLineaID");
            ViewBag.LineaTelefonicaID = new SelectList(db.Venta, "VentaID", "VentaID");
            return View();
        }

        // POST: LineaTelefonicas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LineaTelefonicaID,AdministradorLineaID,VentaID,EvaluacionID")] LineaTelefonica lineaTelefonica)
        {
            if (ModelState.IsValid)
            {
                db.LineaTelefonica.Add(lineaTelefonica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AdministradorLineaID = new SelectList(db.AdministradorLinea, "AdministradorLineaID", "AdministradorLineaID", lineaTelefonica.AdministradorLineaID);
            ViewBag.LineaTelefonicaID = new SelectList(db.Venta, "VentaID", "VentaID", lineaTelefonica.LineaTelefonicaID);
            return View(lineaTelefonica);
        }

        // GET: LineaTelefonicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdministradorLineaID = new SelectList(db.AdministradorLinea, "AdministradorLineaID", "AdministradorLineaID", lineaTelefonica.AdministradorLineaID);
            ViewBag.LineaTelefonicaID = new SelectList(db.Venta, "VentaID", "VentaID", lineaTelefonica.LineaTelefonicaID);
            return View(lineaTelefonica);
        }

        // POST: LineaTelefonicas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LineaTelefonicaID,AdministradorLineaID,VentaID,EvaluacionID")] LineaTelefonica lineaTelefonica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lineaTelefonica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AdministradorLineaID = new SelectList(db.AdministradorLinea, "AdministradorLineaID", "AdministradorLineaID", lineaTelefonica.AdministradorLineaID);
            ViewBag.LineaTelefonicaID = new SelectList(db.Venta, "VentaID", "VentaID", lineaTelefonica.LineaTelefonicaID);
            return View(lineaTelefonica);
        }

        // GET: LineaTelefonicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // POST: LineaTelefonicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(id);
            db.LineaTelefonica.Remove(lineaTelefonica);
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

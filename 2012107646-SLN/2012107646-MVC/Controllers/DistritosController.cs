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
    public class DistritosController : Controller
    {
        private PaulDbContext db = new PaulDbContext();

        // GET: Distritos
        public ActionResult Index()
        {
            var distrito = db.Distrito.Include(d => d.Provincia);
            return View(distrito.ToList());
        }

        // GET: Distritos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = db.Distrito.Find(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // GET: Distritos/Create
        public ActionResult Create()
        {
            ViewBag.ProvinciaID = new SelectList(db.Provincia, "ProvinciaID", "CadenaUbigeo");
            return View();
        }

        // POST: Distritos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DistritoID,ProvinciaID,CadenaUbigeo")] Distrito distrito)
        {
            if (ModelState.IsValid)
            {
                db.Distrito.Add(distrito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProvinciaID = new SelectList(db.Provincia, "ProvinciaID", "CadenaUbigeo", distrito.ProvinciaID);
            return View(distrito);
        }

        // GET: Distritos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = db.Distrito.Find(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProvinciaID = new SelectList(db.Provincia, "ProvinciaID", "CadenaUbigeo", distrito.ProvinciaID);
            return View(distrito);
        }

        // POST: Distritos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DistritoID,ProvinciaID,CadenaUbigeo")] Distrito distrito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(distrito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProvinciaID = new SelectList(db.Provincia, "ProvinciaID", "CadenaUbigeo", distrito.ProvinciaID);
            return View(distrito);
        }

        // GET: Distritos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = db.Distrito.Find(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // POST: Distritos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Distrito distrito = db.Distrito.Find(id);
            db.Distrito.Remove(distrito);
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

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
    public class EquipoCelularsController : Controller
    {
        private PaulDbContext db = new PaulDbContext();

        // GET: EquipoCelulars
        public ActionResult Index()
        {
            var equipoCelular = db.EquipoCelular.Include(e => e.AdministradorEquipo);
            return View(equipoCelular.ToList());
        }

        // GET: EquipoCelulars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = db.EquipoCelular.Find(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // GET: EquipoCelulars/Create
        public ActionResult Create()
        {
            ViewBag.AdministradorEquipoID = new SelectList(db.AdministradorEquipo, "AdministradorEquipoID", "AdministradorEquipoID");
            return View();
        }

        // POST: EquipoCelulars/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EquipoCelularID,AdministradorEquipoID,EvaluacionID")] EquipoCelular equipoCelular)
        {
            if (ModelState.IsValid)
            {
                db.EquipoCelular.Add(equipoCelular);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AdministradorEquipoID = new SelectList(db.AdministradorEquipo, "AdministradorEquipoID", "AdministradorEquipoID", equipoCelular.AdministradorEquipoID);
            return View(equipoCelular);
        }

        // GET: EquipoCelulars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = db.EquipoCelular.Find(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdministradorEquipoID = new SelectList(db.AdministradorEquipo, "AdministradorEquipoID", "AdministradorEquipoID", equipoCelular.AdministradorEquipoID);
            return View(equipoCelular);
        }

        // POST: EquipoCelulars/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EquipoCelularID,AdministradorEquipoID,EvaluacionID")] EquipoCelular equipoCelular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipoCelular).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AdministradorEquipoID = new SelectList(db.AdministradorEquipo, "AdministradorEquipoID", "AdministradorEquipoID", equipoCelular.AdministradorEquipoID);
            return View(equipoCelular);
        }

        // GET: EquipoCelulars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = db.EquipoCelular.Find(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // POST: EquipoCelulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EquipoCelular equipoCelular = db.EquipoCelular.Find(id);
            db.EquipoCelular.Remove(equipoCelular);
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

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
    public class TipoTrabajadorsController : Controller
    {
        private PaulDbContext db = new PaulDbContext();

        // GET: TipoTrabajadors
        public ActionResult Index()
        {
            return View(db.TipoTrabajador.ToList());
        }

        // GET: TipoTrabajadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTrabajador tipoTrabajador = db.TipoTrabajador.Find(id);
            if (tipoTrabajador == null)
            {
                return HttpNotFound();
            }
            return View(tipoTrabajador);
        }

        // GET: TipoTrabajadors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoTrabajadors/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoTrabajadorID,TrabajadorID")] TipoTrabajador tipoTrabajador)
        {
            if (ModelState.IsValid)
            {
                db.TipoTrabajador.Add(tipoTrabajador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoTrabajador);
        }

        // GET: TipoTrabajadors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTrabajador tipoTrabajador = db.TipoTrabajador.Find(id);
            if (tipoTrabajador == null)
            {
                return HttpNotFound();
            }
            return View(tipoTrabajador);
        }

        // POST: TipoTrabajadors/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoTrabajadorID,TrabajadorID")] TipoTrabajador tipoTrabajador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoTrabajador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoTrabajador);
        }

        // GET: TipoTrabajadors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTrabajador tipoTrabajador = db.TipoTrabajador.Find(id);
            if (tipoTrabajador == null)
            {
                return HttpNotFound();
            }
            return View(tipoTrabajador);
        }

        // POST: TipoTrabajadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoTrabajador tipoTrabajador = db.TipoTrabajador.Find(id);
            db.TipoTrabajador.Remove(tipoTrabajador);
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

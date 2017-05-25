using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrabajoF.Entities;
using TrabajoF.Persistence;

namespace TrabajoF.MVC.Controllers
{
    public class LocalLibreriasController : Controller
    {
        private TrabajoFinalDbContext db = new TrabajoFinalDbContext();

        // GET: LocalLibrerias
        public ActionResult Index()
        {
            return View(db.LocalLibrerias.ToList());
        }

        // GET: LocalLibrerias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalLibreria localLibreria = db.LocalLibrerias.Find(id);
            if (localLibreria == null)
            {
                return HttpNotFound();
            }
            return View(localLibreria);
        }

        // GET: LocalLibrerias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocalLibrerias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LocalLibreriaid,Direccion")] LocalLibreria localLibreria)
        {
            if (ModelState.IsValid)
            {
                db.LocalLibrerias.Add(localLibreria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(localLibreria);
        }

        // GET: LocalLibrerias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalLibreria localLibreria = db.LocalLibrerias.Find(id);
            if (localLibreria == null)
            {
                return HttpNotFound();
            }
            return View(localLibreria);
        }

        // POST: LocalLibrerias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocalLibreriaid,Direccion")] LocalLibreria localLibreria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(localLibreria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(localLibreria);
        }

        // GET: LocalLibrerias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalLibreria localLibreria = db.LocalLibrerias.Find(id);
            if (localLibreria == null)
            {
                return HttpNotFound();
            }
            return View(localLibreria);
        }

        // POST: LocalLibrerias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LocalLibreria localLibreria = db.LocalLibrerias.Find(id);
            db.LocalLibrerias.Remove(localLibreria);
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

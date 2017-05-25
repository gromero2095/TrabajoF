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
    public class LibreriasController : Controller
    {
        private TrabajoFinalDbContext db = new TrabajoFinalDbContext();

        // GET: Librerias
        public ActionResult Index()
        {
            var librerias = db.Librerias.Include(l => l.LocalLibreria);
            return View(librerias.ToList());
        }

        // GET: Librerias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libreria libreria = db.Librerias.Find(id);
            if (libreria == null)
            {
                return HttpNotFound();
            }
            return View(libreria);
        }

        // GET: Librerias/Create
        public ActionResult Create()
        {
            ViewBag.LocalLibreriaId = new SelectList(db.LocalLibrerias, "LocalLibreriaid", "Direccion");
            return View();
        }

        // POST: Librerias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Libreriaid,Nombre,RUCLibreria,LocalLibreriaId")] Libreria libreria)
        {
            if (ModelState.IsValid)
            {
                db.Librerias.Add(libreria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LocalLibreriaId = new SelectList(db.LocalLibrerias, "LocalLibreriaid", "Direccion", libreria.LocalLibreriaId);
            return View(libreria);
        }

        // GET: Librerias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libreria libreria = db.Librerias.Find(id);
            if (libreria == null)
            {
                return HttpNotFound();
            }
            ViewBag.LocalLibreriaId = new SelectList(db.LocalLibrerias, "LocalLibreriaid", "Direccion", libreria.LocalLibreriaId);
            return View(libreria);
        }

        // POST: Librerias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Libreriaid,Nombre,RUCLibreria,LocalLibreriaId")] Libreria libreria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libreria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LocalLibreriaId = new SelectList(db.LocalLibrerias, "LocalLibreriaid", "Direccion", libreria.LocalLibreriaId);
            return View(libreria);
        }

        // GET: Librerias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libreria libreria = db.Librerias.Find(id);
            if (libreria == null)
            {
                return HttpNotFound();
            }
            return View(libreria);
        }

        // POST: Librerias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Libreria libreria = db.Librerias.Find(id);
            db.Librerias.Remove(libreria);
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

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
    public class CarritosController : Controller
    {
        private TrabajoFinalDbContext db = new TrabajoFinalDbContext();

        // GET: Carritos
        public ActionResult Index()
        {
            var carritos = db.Carritos.Include(c => c.Cliente).Include(c => c.Venta);
            return View(carritos.ToList());
        }

        // GET: Carritos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carrito carrito = db.Carritos.Find(id);
            if (carrito == null)
            {
                return HttpNotFound();
            }
            return View(carrito);
        }

        // GET: Carritos/Create
        public ActionResult Create()
        {
            ViewBag.Carritoid = new SelectList(db.Clientes, "Clienteid", "Nombres");
            ViewBag.Carritoid = new SelectList(db.Ventas, "Ventaid", "Libro");
            return View();
        }

        // POST: Carritos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Carritoid,Correo,Telefono,EnviarNom,EnviarApe,EnviarDireccion,EnviarDistrito")] Carrito carrito)
        {
            if (ModelState.IsValid)
            {
                db.Carritos.Add(carrito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Carritoid = new SelectList(db.Clientes, "Clienteid", "Nombres", carrito.Carritoid);
            ViewBag.Carritoid = new SelectList(db.Ventas, "Ventaid", "Libro", carrito.Carritoid);
            return View(carrito);
        }

        // GET: Carritos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carrito carrito = db.Carritos.Find(id);
            if (carrito == null)
            {
                return HttpNotFound();
            }
            ViewBag.Carritoid = new SelectList(db.Clientes, "Clienteid", "Nombres", carrito.Carritoid);
            ViewBag.Carritoid = new SelectList(db.Ventas, "Ventaid", "Libro", carrito.Carritoid);
            return View(carrito);
        }

        // POST: Carritos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Carritoid,Correo,Telefono,EnviarNom,EnviarApe,EnviarDireccion,EnviarDistrito")] Carrito carrito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carrito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Carritoid = new SelectList(db.Clientes, "Clienteid", "Nombres", carrito.Carritoid);
            ViewBag.Carritoid = new SelectList(db.Ventas, "Ventaid", "Libro", carrito.Carritoid);
            return View(carrito);
        }

        // GET: Carritos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carrito carrito = db.Carritos.Find(id);
            if (carrito == null)
            {
                return HttpNotFound();
            }
            return View(carrito);
        }

        // POST: Carritos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Carrito carrito = db.Carritos.Find(id);
            db.Carritos.Remove(carrito);
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

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

namespace VentasLibros.MVC.Controllers
{
    public class LibroesController : Controller
    {
        private TrabajoFDbContext db = new TrabajoFDbContext();

        // GET: Libroes
        public ActionResult Index()
        {
            var libros = db.Libros.Include(l => l.Autor).Include(l => l.Carrito).Include(l => l.Empleados).Include(l => l.Venta);
            return View(libros.ToList());
        }

        // GET: Libroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            return View(libro);
        }

        // GET: Libroes/Create
        public ActionResult Create()
        {
            ViewBag.Autorid = new SelectList(db.Autores, "Autorid", "Nombre");
            ViewBag.Carritoid = new SelectList(db.Carritos, "Carritoid", "Correo");
            ViewBag.Empleadoid = new SelectList(db.Empleados, "Empleadoid", "Nombres");
            ViewBag.Ventaid = new SelectList(db.Ventas, "Ventaid", "Libro");
            return View();
        }

        // POST: Libroes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Libroid,Editorial,Precio,Estado,Stock,AñoPublicacion,Valoracion,Autorid,Carritoid,TipoLibro,Categoria,Ventaid,Empleadoid")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                db.Libros.Add(libro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Autorid = new SelectList(db.Autores, "Autorid", "Nombre", libro.Autorid);
            ViewBag.Carritoid = new SelectList(db.Carritos, "Carritoid", "Correo", libro.Carritoid);
            ViewBag.Empleadoid = new SelectList(db.Empleados, "Empleadoid", "Nombres", libro.Empleadoid);
            ViewBag.Ventaid = new SelectList(db.Ventas, "Ventaid", "Libro", libro.Ventaid);
            return View(libro);
        }

        // GET: Libroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            ViewBag.Autorid = new SelectList(db.Autores, "Autorid", "Nombre", libro.Autorid);
            ViewBag.Carritoid = new SelectList(db.Carritos, "Carritoid", "Correo", libro.Carritoid);
            ViewBag.Empleadoid = new SelectList(db.Empleados, "Empleadoid", "Nombres", libro.Empleadoid);
            ViewBag.Ventaid = new SelectList(db.Ventas, "Ventaid", "Libro", libro.Ventaid);
            return View(libro);
        }

        // POST: Libroes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Libroid,Editorial,Precio,Estado,Stock,AñoPublicacion,Valoracion,Autorid,Carritoid,TipoLibro,Categoria,Ventaid,Empleadoid")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Autorid = new SelectList(db.Autores, "Autorid", "Nombre", libro.Autorid);
            ViewBag.Carritoid = new SelectList(db.Carritos, "Carritoid", "Correo", libro.Carritoid);
            ViewBag.Empleadoid = new SelectList(db.Empleados, "Empleadoid", "Nombres", libro.Empleadoid);
            ViewBag.Ventaid = new SelectList(db.Ventas, "Ventaid", "Libro", libro.Ventaid);
            return View(libro);
        }

        // GET: Libroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            return View(libro);
        }

        // POST: Libroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Libro libro = db.Libros.Find(id);
            db.Libros.Remove(libro);
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

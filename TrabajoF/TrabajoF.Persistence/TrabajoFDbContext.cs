using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence
{
    public class TrabajoFDbContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Libreria> Librerias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<LocalLibreria> LocalLibrerias { get; set; }
        public DbSet<Nacionalidad> Nacionalidades { get; set; }
        public DbSet<Venta> Ventas { get; set; }

            
        }
}

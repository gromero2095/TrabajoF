using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;
using TrabajoF.Persistence.EntityTypeConfigurations;

namespace TrabajoF.Persistence
{
    public class TrabajoFinalDbContext : DbContext
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


        // Remover la pluralizacion o el nombre de las tablas en la base de datos
        // podemos especificar el comportamiento que tenga el trabajo hacia la base de datos
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorConfiguration());
            modelBuilder.Configurations.Add(new CarritoConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ComprobanteConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new LibreriaConfiguration());
            modelBuilder.Configurations.Add(new LibroConfiguration());
            modelBuilder.Configurations.Add(new LocalLibreriaConfiguration());
            modelBuilder.Configurations.Add(new NacionalidadConfiguration());
            modelBuilder.Configurations.Add(new PagoConfiguration());
            modelBuilder.Configurations.Add(new VentaConfiguration());

            Database.SetInitializer<TrabajoFinalDbContext>(null);
            base.OnModelCreating(modelBuilder);

            /*
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

                #region Autor
                modelBuilder.Entity<Autor>()
                             .Property(x => x.Nombre)
                             .HasMaxLength(50)
                             .IsRequired();

                modelBuilder.Entity<Autor>()
                             .Property(x => x.Apellido)
                             .HasMaxLength(100)
                             .IsRequired();
                modelBuilder.Entity<Autor>()
                             .Property(v => v.FechadeNacimiento)
                             .IsRequired()
                             .HasMaxLength(80);
                #endregion

                */


        }

        public System.Data.Entity.DbSet<TrabajoF.Entities.Pago> Pagoes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class LibroConfiguration : EntityTypeConfiguration<Libro>
    {
        public LibroConfiguration()
        {
            Property(v => v.Editorial)
                .IsRequired()
                .HasMaxLength(255);
            Property(v => v.Estado)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.Valoracion)
                .IsRequired()
                .HasMaxLength(100);

            //Relacion Libro - Autor
            HasRequired(v => v.Autor)
                  .WithMany(l => l.Libros)
                  .HasForeignKey(v => v.Autorid);


            //Relacion Libro - Carrito
            HasRequired(v => v.Carrito)
                     .WithMany(g => g.Libros)
                     .HasForeignKey(v => v.Carritoid);

            //Relacion Libros - Venta
            HasRequired(v => v.Venta)
                     .WithMany(g => g.Libros)
                     .HasForeignKey(v => v.Ventaid);

        


        }
    }
}

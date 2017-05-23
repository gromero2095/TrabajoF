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
            ToTable("Libro")
                .HasKey(c => c.Libroid);

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
      /*      HasMany(c => c.Autores)
                 .WithMany(t => t.Libros)
                 .Map(m => m.ToTable("Autores"));
*/


        
            

        


        }
    }
}

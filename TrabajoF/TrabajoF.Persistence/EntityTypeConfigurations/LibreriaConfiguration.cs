using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class LibreriaConfiguration : EntityTypeConfiguration<Libreria>
    {

        public LibreriaConfiguration()
        {
            Property(v => v.Nombre)
                .IsRequired()
                .HasMaxLength(255);


            HasMany(v => v.Empleados)
                .WithMany(t => t.Librerias)
                .Map(m =>
                {
                    m.ToTable("LocalLibreria");
                    m.MapLeftKey("Libreriaid");
                    m.MapRightKey("Empleadoid");
                }
                );

        }
    }
}

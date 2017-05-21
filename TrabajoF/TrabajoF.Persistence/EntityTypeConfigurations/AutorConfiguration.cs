using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class AutorConfiguration : EntityTypeConfiguration<Autor>
    {
        public AutorConfiguration()
        {
            Property(v => v.Nombre)
                .IsRequired()
                .HasMaxLength(50);
            Property(v => v.Apellido)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.FechadeNacimiento)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(v => v.Nacionalidad)
                     .WithMany(t => t.Autores)
                     .HasForeignKey(v => v.Nacionalidadid);

        }
    }
}

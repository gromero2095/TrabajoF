using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class NacionalidadConfiguration : EntityTypeConfiguration<Nacionalidad>
    {
        public NacionalidadConfiguration()
        {
            ToTable("Nacionalidad")
             .HasKey(c => c.Nacionalidadid);

            Property(v => v.Nombre)
                .IsRequired()
                .HasMaxLength(255);

            HasMany(a => a.Autores)
                .WithRequired(c => c.Nacionalidad)
                .HasForeignKey(c => c.Nacionalidadid);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class PagoConfiguration : EntityTypeConfiguration<Pago>
    {
        public PagoConfiguration()
        {
            Property(v => v.Descripcion)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}

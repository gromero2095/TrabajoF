using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class ComprobanteConfiguration : EntityTypeConfiguration<Comprobante>
    {

        public ComprobanteConfiguration()
        {
            ToTable("Comprobante")
             .HasKey(c => c.Comprobanteid);

            Property(v => v.Descripcion)
                .IsRequired()
                .HasMaxLength(255);

        
        }
    }
}

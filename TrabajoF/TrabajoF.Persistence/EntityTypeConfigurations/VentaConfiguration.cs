using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class VentaConfiguration : EntityTypeConfiguration<Venta>

    {
        public VentaConfiguration ()
        {
            Property(v => v.Libro)
               .IsRequired()
               .HasMaxLength(255);

            Property(v => v.Estado)
                .IsRequired()
                .HasMaxLength(50);

            //Relacion Venta - Cliente


            //Relacion Venta - Comprobante



        }
    }
}

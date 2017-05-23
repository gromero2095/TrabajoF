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
            ToTable("Venta")
                .HasKey(c => c.Ventaid);

            Property(v => v.Libro)
               .IsRequired()
               .HasMaxLength(255);

            Property(v => v.Estado)
                .IsRequired()
                .HasMaxLength(50);

            HasOptional(c => c.Carrito)
                .WithRequired(c => c.Venta);

            HasRequired(c => c.Pago)
                .WithRequiredPrincipal(c => c.Venta);

            HasRequired(c => c.Comprobante)
                .WithRequiredPrincipal(c => c.Venta);

        }
    }
}

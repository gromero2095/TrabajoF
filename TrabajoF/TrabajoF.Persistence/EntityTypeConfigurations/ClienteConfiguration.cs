using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            Property(v => v.Nombres)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.ApeMaterno)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.ApePaterno)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.Direccion)
                .IsRequired()
                .HasMaxLength(150);
            Property(v => v.Sexo)
                .IsRequired()
                .HasMaxLength(50);
            Property(v => v.Correo)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}

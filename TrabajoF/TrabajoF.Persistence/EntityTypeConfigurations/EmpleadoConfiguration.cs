using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class EmpleadoConfiguration : EntityTypeConfiguration<Empleado>
    {
        public EmpleadoConfiguration()
        {
            ToTable("Empleado")
             .HasKey(c => c.Empleadoid);

            Property(v => v.Nombres)
                .IsRequired()
                .HasMaxLength(50);
            Property(v => v.ApePaterno)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.ApeMaterno)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.Sexo)
                .IsRequired()
                .HasMaxLength(25);
            Property(v => v.Estado)
                .IsRequired()
                .HasMaxLength(200);
            Property(v => v.Direccion)
                .IsRequired()
                .HasMaxLength(255);
            Property(v => v.Correo)
                .IsRequired()
                .HasMaxLength(150);

            HasMany(a => a.Libros)
                 .WithRequired(c => c.Empleados)
                 .HasForeignKey(c => c.Empleadoid);

            HasRequired(c => c.Locallibreria)
                 .WithRequiredPrincipal(c => c.Empleado);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class CarritoConfiguration : EntityTypeConfiguration<Carrito>
    {

        public CarritoConfiguration()
        {
            Property(v => v.Correo)
                .IsRequired()
                .HasMaxLength(255);
            Property(v => v.EnviarNom)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.EnviarApe)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.EnviarDireccion)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.EnviarDistrito)
                .IsRequired()
                .HasMaxLength(100);

           



        }
    }
}

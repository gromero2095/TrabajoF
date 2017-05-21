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

        }
    }
}

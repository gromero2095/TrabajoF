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
            ToTable("Libreria")
             .HasKey(c => c.Libreriaid);

            Property(v => v.Nombre)
                .IsRequired()
                .HasMaxLength(255);

            //     HasMany (v => v.LocalLibrerias)
            //           .WithRequired(l => l.Libreria)
            //          .HasForeignKey(v => v.LocalLibreriaid);

            HasRequired(i => i.LocalLibreria)
                 .WithRequiredDependent()
                 .WillCascadeOnDelete(false);

            HasRequired<LocalLibreria>(i => i.LocalLibreria)
                .WithMany(e => e.LocalxLibreria)
                .HasForeignKey(i => i.LocalLibreriaId);

        }
    }
}

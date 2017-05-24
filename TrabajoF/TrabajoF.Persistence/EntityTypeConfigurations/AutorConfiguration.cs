using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class AutorConfiguration : EntityTypeConfiguration<Autor>
    {
        public AutorConfiguration()
        {
            ToTable("Autor")
                .HasKey(c => c.Autorid);

            Property(v => v.Nombre)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnOrder(2);

            Property(v => v.Apellido)
                .IsRequired()
                .HasMaxLength(100);
            Property(v => v.FechadeNacimiento)
                .IsRequired()
                .HasMaxLength(100);

            HasMany(c => c.Libros)
                 .WithRequired(t => t.Autor)
                 .HasForeignKey(t=>t.Autorid);


        }
    }
}

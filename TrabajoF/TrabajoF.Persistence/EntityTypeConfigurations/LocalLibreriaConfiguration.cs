﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class LocalLibreriaConfiguration : EntityTypeConfiguration<LocalLibreria>
    {
        public LocalLibreriaConfiguration()
        {
            ToTable("LocalxLibreria")
                .HasKey(c => c.LocalLibreriaid);

            Property(v => v.Direccion)
                .IsRequired()
                .HasMaxLength(255);

            HasRequired(c => c.Empleado)
               .WithRequiredPrincipal(c => c.Locallibreria);

            HasMany(c => c.Ventas)
                   .WithRequired(l => l.Locallibreria)
                    .HasForeignKey(l => l.LocalLibreriaId);
             

        }
    }
}

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
            Property(v => v.Direccion)
                .IsRequired()
                .HasMaxLength(255);

            

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;

namespace TrabajoF.Persistence.EntityTypeConfigurations
{
    class LibroConfiguration : EntityTypeConfiguration<Libro>
    {
        public LibroConfiguration()
        {
            Property(v => v.Editorial)
                .IsRequired()
                .HasMaxLength(255);

          /*  HasRequired(v => v.Autor)
                .WithMany(l => l.Libro)
                .HasForeignKey(v => v.Autorid);
                */
      
            

        }
    }
}

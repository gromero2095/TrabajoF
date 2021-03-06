﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Libro
    {
        //Varibles de instancia
        public int Libroid { get; set; }
        public string Editorial { get; set; }
        public Decimal Precio { get; set; }
        public string Estado { get; set; }
        public int Stock { get; set; }
        public DateTime AñoPublicacion { get; set; }
        public string Valoracion { get; set; }

        //Relaciones
       public Autor Autor { get; set;}
        public int Autorid { get; set; }
        public Carrito Carrito { get; set; }
        public int Carritoid { get; set; }
        public TipoLibro TipoLibro { get; set; }     
        public Categoria Categoria { get; set; }
        public Collection<Autor> Autores { get; set; }
        public Venta Venta { get; set; }
        public int? Ventaid { get; set; }
        public Empleado Empleados { get; set; }
        public int Empleadoid { get; set; }

        public Libro()
        {
            TipoLibro = TipoLibro.NoDefinido;
           Autores = new Collection<Autor>();
            Categoria = Categoria.NoDefinido; 
        }
        
   /*     public Libro(int AutorId)
        {
            Autores = new List<Autor>(AutorId);

        }
    */
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Libro
    {
        public int Libroid { get; set; }
        public string Editorial { get; set; }
        public double Precio { get; set; }
        public string Estado { get; set; }
        public int Stock { get; set; }
        public DateTime AñoPublicacion { get; set; }
        public string Valoracion { get; set; }
        public Autor Autor { get; set;}
        public int Autorid { get; set; }
        public Carrito Carrito { get; set; }
        public int Carritoid { get; set; }
        public TipoLibro TipoLibro { get; set; }     
        public Categoria Categoria { get; set; }
        public List<Autor> Autores { get; set; }
        public Venta Venta { get; set; }
        public int Ventaid { get; set; }

        public Libro()
        {
            Autores = new List<Autor>();

        }
    }
}

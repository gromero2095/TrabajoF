using System;
using System.Collections.Generic;
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

        public Libro()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Autor
    {
        public int Autorid { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechadeNacimiento { get; set; }
        public List<Libro>  Libro{ get; set; }

        public Autor()
        {
            Libro = new List<Libro>();
        }
    }
}

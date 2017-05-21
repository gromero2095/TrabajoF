using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Carrito
    {
        public int Carritoid { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string EnviarNom { get; set; }
        public string EnviarApe { get; set; }
        public string EnviarDireccion { get; set; }
        public string EnviarDistrito { get; set; }
        public List<Libro> Libros { get; set; }

        public Carrito()
        {
            Libros = new List<Libro>();
        }
    }
}

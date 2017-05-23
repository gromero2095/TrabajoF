using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Autor
    {
        //Variables de Instancia
        public int Autorid { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechadeNacimiento { get; set; }

        //Relaciones
        public List<Libro> Libros{ get; set; }
        public int Libroid { get; set; }
        public Nacionalidad Nacionalidad { get; set; }
        public int Nacionalidadid { get; set; }


        public Autor()
        {
            Libros = new List<Libro>();
        }

        public Autor(int LibroId, Nacionalidad nacionalidad)
        {
            Nacionalidad = nacionalidad;
            Libros = new List<Libro>(LibroId);

        }

    }
}

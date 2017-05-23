using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Empleado
    {
        public int Empleadoid { get; set; }
        public string Nombres { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public int Telefono { get; set; }
        public string Sexo { get; set; }
        public int FechaIngreso { get; set; }
        public string Estado { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public TipoEmpleado TipoEmpleado { get; set; }
        public LocalLibreria Locallibreria { get; set; }
        public int LocalLibreriaid { get; set; }
        public Libro Libro { get; set; }
        public int Libroid { get; set; }

        public List<Libro> Libros { get; set; }

        public Empleado()
        {
            TipoEmpleado = TipoEmpleado.NoDefinido;
            Libros = new List<Libro>();
        }

        public Empleado(int empleadoId)
        {
            Empleadoid = empleadoId;
        }
        
}
}

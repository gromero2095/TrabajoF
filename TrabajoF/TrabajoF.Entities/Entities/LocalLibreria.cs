using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class LocalLibreria
    {

        public int LocalLibreriaid { get; set; }
        public string Direccion { get; set; }
        public Empleado Empleado { get; set; }
        public int Empleadoid { get; set; }
        public Libreria Libreria { get; set; }
        public int Libreriaid { get; set; }


        public LocalLibreria()
        {

        }
        
}
}

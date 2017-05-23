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
        public Libreria Libreria { get; set; }
        public int Libreriaid { get; set; }
        private List<Empleado> Empleados;
        public List<Venta> Ventas { get; set; }

        public LocalLibreria(int localLibreriaId, string direccion, int empleadoId)
        {
            LocalLibreriaid = localLibreriaId;
            Direccion = direccion;

            Empleados = new List<Empleado>(empleadoId);

        }
        
}
}

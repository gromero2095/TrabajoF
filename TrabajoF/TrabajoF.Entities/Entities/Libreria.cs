using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Libreria
    {
        public int Libreriaid { get; set; }
        public string Nombre { get; set; }
        public int RUCLibreria { get; set; }
        public List<Empleado> Empleados { get; set; }
        public List<LocalLibreria> LocalLibrerias { get; set; }
        public Empleado EmpleadoId{ get; set; }
        public LocalLibreria LocalLibreriaId { get; set; }

        public Libreria()
        {
            Empleados = new List<Empleado>();
            LocalLibrerias = new List<LocalLibreria>();
        }
        public Libreria(int empleadoId, int localLibreria, int libreriaId)
        {
            Libreriaid = libreriaId;

            LocalLibrerias = new List<LocalLibreria>(localLibreria);
            Empleados = new List<Empleado>(empleadoId);
        }
    }
}

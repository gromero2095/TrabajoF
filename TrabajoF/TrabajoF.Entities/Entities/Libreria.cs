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
        public List<LocalLibreria> LocalLibrerias { get; set; }

        

        public Libreria()
        {
            LocalLibrerias = new List<LocalLibreria>();
        }
        public Libreria(int empleadoId, int localLibreriaid, int libreriaId)
        {
            Libreriaid = libreriaId;

            LocalLibrerias = new List<LocalLibreria>(localLibreriaid);

        }
    }
}

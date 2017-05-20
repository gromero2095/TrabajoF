using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Venta
    {
        public int Ventaid { get; set; }
        public string Libros { get; set; }
        public int MontoTotal { get; set; }
        public int FechaTrans { get; set; }
        public string ModalidadRecogo { get; set; }
        public string Estado { get; set; }

        public Venta()
        {

        }
    }
}

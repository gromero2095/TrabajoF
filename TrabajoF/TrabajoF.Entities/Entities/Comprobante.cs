using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Comprobante
    {
        public int Comprobanteid { get; set; }
        public int Fecha { get; set; }
        public int Total { get; set; }
        public Cliente Cliente { get; set; }
        public int Clienteid { get; set; }
        public Venta Venta { get; set; }
        public int Ventaid { get; set; }
        public Envio Envio { get; set; }

        public Comprobante()
        {

        }
    }
}

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
        public string Descripcion { get; set; }
        public int Fecha { get; set; }
        public int Total { get; set; }
        public Cliente Cliente { get; set; }
        public int Clienteid { get; set; }
        public List<Venta> Ventas { get; set; }
        public Envio Envio { get; set; }

        public Comprobante()
        {

        }
    }
}

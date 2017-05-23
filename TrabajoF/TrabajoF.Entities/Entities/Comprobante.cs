using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Comprobante
    {
        //Variables de instancia
        public int Comprobanteid { get; set; }
        public string Descripcion { get; set; }
        public int Fecha { get; set; }
        public int Total { get; set; }

        //Relaciones
        public Cliente Cliente { get; set; }
        public int Clienteid { get; set; }
        public Venta Venta { get; set; }
        public int Ventasid { get; set; }
        public Envio Envio { get; set; }

        public Comprobante(Cliente cliente, Venta venta)
        {
            Cliente = cliente;
            Venta = venta;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Venta
    {
        //Variables de instancia
        public int Ventaid { get; set; }
        public string Libro { get; set; }
        public int MontoTotal { get; set; }
        public int FechaTrans { get; set; }
        public string Estado { get; set; }

        
        public Carrito Carrito { get; set; }
        public int Carritoid { get; set; }
        
        public Pago Pago{ get; set; }
        public Envio Envio { get; set; }


        public Venta()
        {
            Envio = Envio.Recojo_Libreria;
        }

        public Venta(Carrito carrito, Pago pago)
        {
            Carrito = carrito;
            Pago = pago;
        }
    }
}

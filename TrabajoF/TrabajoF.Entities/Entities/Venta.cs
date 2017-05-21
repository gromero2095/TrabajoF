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
        public string Libro { get; set; }
        public int MontoTotal { get; set; }
        public int FechaTrans { get; set; }
        public string Estado { get; set; }

        
        public Carrito Carrito { get; set; }
        public int Carritoid { get; set; }
        public Cliente Cliente { get; set; }
        public int Clienteid { get; set; }
        public Pago Pago{ get; set; }
        public Envio Envio { get; set; }
        public Comprobante Comprobante { get; set; }
        public int Comprobanteid{ get; set; }
        public List<Libro> Libros{ get; set; }

        public Venta()
        {
            Libros = new List<Libro>();
        }
        /*
        public Venta(Cliente cliente, Pago pago, Envio envio,int libroId,int ventaId  )
        {
            Ventaid = ventaId;
            Cliente = cliente;
            Pago = pago;
            Envio = envio;
        }

    */
    }
}

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
        public List<Libro> Libro { get; set; }
        public Cliente Cliente { get; set; }
        public Pago Pago{ get; set; }
        public Envio Envio { get; set; }

        public Venta()
        {
            Libro = new List<Libro>();

        }
        public Venta(Cliente cliente, Pago pago, Envio envio,int libroId,int ventaId  )
        {
            Ventaid = ventaId;
            Libro = new List<Libro>(libroId);
            Cliente = cliente;
            Pago = pago;
            Envio = envio;


        }

    }
}

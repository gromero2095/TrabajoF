using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Cliente
    {
        public int Clienteid { get; set; }
        public int DNI { get; set; }
        public int RUCCliente { get; set; }
        public string Nombres { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Sexo { get; set; }
        public string Correo { get; set; }
        public List <Venta> Ventas{ get; set; }

        public Comprobante Comprobante { get; set; }
        public int Comprobanteid { get; set; }
        public List <Comprobante> Comprobantes { get; set; }
        public Carrito Carrito { get; set; }

        public Cliente()
        {
            Comprobantes = new List<Comprobante>();
            
        }
}
}

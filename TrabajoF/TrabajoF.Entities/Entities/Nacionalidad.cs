using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities
{
    public class Nacionalidad
    {
        public int Nacionalidadid { get; set; }
        public string Nombre { get; set; }
        public List<Autor> Autores { get; set; }

        public Nacionalidad()
        {
            Autores = new List<Autor>();
          
        }
}
}

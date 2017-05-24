using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities.IRepositories
{
    public interface IVentaRepository : IRepository <Venta>
    {
        IEnumerable<Venta> GetVentasByTipoPago(TipoPago TipoPago);

    }
}

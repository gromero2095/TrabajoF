using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;
using TrabajoF.Entities.IRepositories;

namespace TrabajoF.Persistence.Repositories
{
    public class VentaRepository : Repository<Venta>, IVentaRepository
    {
        /*   private readonly TrabajoFinalDbContext _Context;

           public VentaRepository(TrabajoFinalDbContext context)
           {
               _Context = context;
           }
           private VentaRepository()
           {

           }

           IEnumerable<Venta> IVentaRepository.GetVentasByTipoPago(TipoPago TipoPago)
           {
               throw new NotImplementedException();
           }
           */
        public VentaRepository(TrabajoFinalDbContext context) : base(context)
        {
        }
    }
}

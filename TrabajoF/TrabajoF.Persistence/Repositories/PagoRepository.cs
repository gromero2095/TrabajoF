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
    public class PagoRepository : Repository<Pago>, IPagoRepository
    {

        /*  private readonly TrabajoFinalDbContext _Context;

          public PagoRepository(TrabajoFinalDbContext context)
          {
              _Context = context;
          }
          private PagoRepository()
          {

          }
          */
        public PagoRepository(TrabajoFinalDbContext context) : base(context)
        {
        }
    }
}

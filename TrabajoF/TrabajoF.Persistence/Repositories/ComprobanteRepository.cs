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
    public class ComprobanteRepository : Repository<Comprobante>, IComprobanteRepository
    {


        /*private readonly TrabajoFinalDbContext _Context;

        public ComprobanteRepository(TrabajoFinalDbContext context)
        {
            _Context = context;
        }
        private ComprobanteRepository()
        {

        }
        */
        public ComprobanteRepository(TrabajoFinalDbContext context) : base(context)
        {
        }
    }
}

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
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {


        /*        private readonly TrabajoFinalDbContext _Context;

                public ClienteRepository(TrabajoFinalDbContext context)
                {
                    _Context = context;
                }

                private ClienteRepository()
                {

                }
                */
        public ClienteRepository(TrabajoFinalDbContext context) : base(context)
        {
        }
    }
}

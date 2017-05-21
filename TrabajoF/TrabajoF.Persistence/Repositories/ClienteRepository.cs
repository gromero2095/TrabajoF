using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;
using TrabajoF.Entities.IRepositories;

namespace TrabajoF.Persistence.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly TrabajoFDbContext _Context;

        public ClienteRepository(TrabajoFDbContext context)
        {
            _Context = context;
        }

        private ClienteRepository()
        {

        }
    }
}

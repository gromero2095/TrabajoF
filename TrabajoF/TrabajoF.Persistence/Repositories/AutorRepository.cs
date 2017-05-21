using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;
using TrabajoF.Entities.IRepositories;

namespace TrabajoF.Persistence.Repositories
{
    public class AutorRepository : Repository <Autor>, IAutorRepository
    {
        private readonly TrabajoFDbContext _Context;

        private AutorRepository()
        {

        }

        public AutorRepository(TrabajoFDbContext context)
        {

            _Context = context;
        }

    }
}

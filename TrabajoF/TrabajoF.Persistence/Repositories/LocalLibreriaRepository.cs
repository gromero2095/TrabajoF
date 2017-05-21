using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;
using TrabajoF.Entities.IRepositories;

namespace TrabajoF.Persistence.Repositories
{
    public class LocalLibreriaRepository : Repository<LocalLibreria>, ILocalLibreriaRepository
    {
        private readonly TrabajoFDbContext _Context;

        public LocalLibreriaRepository(TrabajoFDbContext context)
        {
            _Context = context;
        }
        private LocalLibreriaRepository()
        {

        }
    }
}

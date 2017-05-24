using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;
using TrabajoF.Entities.IRepositories;

namespace TrabajoF.Persistence.Repositories
{
    public class CarritoRepository : Repository<Carrito>, ICarritoRepository
    {
        private readonly TrabajoFDbContext _Context;

        public CarritoRepository(TrabajoFDbContext context)
        {
            _Context = context;
        }

        private CarritoRepository()
        {

        }
    }
}

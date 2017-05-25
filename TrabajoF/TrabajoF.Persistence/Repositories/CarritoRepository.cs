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
    public class CarritoRepository : Repository<Carrito>, ICarritoRepository
    {
        /*     private readonly TrabajoFinalDbContext _Context;

             public CarritoRepository(TrabajoFinalDbContext context)
             {
                 _Context = context;
             }

             private CarritoRepository()
             {

             }
             */
        public CarritoRepository(TrabajoFinalDbContext context) : base(context)
        {
        }
    }
}

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
    public class NacionalidadRepository : Repository<Nacionalidad>, INacionalidadRepository
    {
        /*     private readonly TrabajoFinalDbContext _Context;

             public NacionalidadRepository(TrabajoFinalDbContext context)
             {
                 _Context = context;
             }
             private NacionalidadRepository()
             {

             }
             */
        public NacionalidadRepository(TrabajoFinalDbContext context) : base(context)
        {
        }
    }
}

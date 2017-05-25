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
    public class LocalLibreriaRepository : Repository<LocalLibreria>, ILocalLibreriaRepository
    {


        /*   private readonly TrabajoFinalDbContext _Context;

           public LocalLibreriaRepository(TrabajoFinalDbContext context)
           {
               _Context = context;
           }
           private LocalLibreriaRepository()
           {

           }
           */
        public LocalLibreriaRepository(TrabajoFinalDbContext context) : base(context)
        {
        }
    }
}

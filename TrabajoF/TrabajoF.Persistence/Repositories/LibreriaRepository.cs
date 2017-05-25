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
    public class LibreriaRepository : Repository<Libreria>, ILibreriaRepository
    {


        /*  private readonly TrabajoFinalDbContext _Context;

          public LibreriaRepository(TrabajoFinalDbContext context)
          {
              _Context = context;
          }
          private LibreriaRepository()
          {

          }
          */
        public LibreriaRepository(TrabajoFinalDbContext context) : base(context)
        {
        }
    }
}

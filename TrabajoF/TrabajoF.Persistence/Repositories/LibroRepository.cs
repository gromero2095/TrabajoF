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
    public class LibroRepository : Repository<Libro>, ILibroRepository
    {


        /* private readonly TrabajoFinalDbContext _Context;

         public LibroRepository(TrabajoFinalDbContext context)
         {
             _Context = context;
         }
         private LibroRepository()
         {

         }
         */
        public LibroRepository(TrabajoFinalDbContext context) : base(context)
        {
        }
    }
}

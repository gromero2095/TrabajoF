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
   //     private readonly TrabajoFinalDbContext _Context;

        public AutorRepository(TrabajoFinalDbContext context) : base(context)
        {

        }

  /*      public AutorRepository(TrabajoFinalDbContext context)
        {

            _Context = context;
        }

        IEnumerable<Autor> IAutorRepository.GetAutoresWithLibros(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Autor> IAutorRepository.GetAutoresByTipoLibro(TipoLibro TipoLibro)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Autor> IAutorRepository.GetAutoresByCategoria(Categoria Categoria)
        {
            throw new NotImplementedException();
        }

    */
    }
}

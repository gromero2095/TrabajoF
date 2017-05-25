using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities.IRepositories
{
   public  interface IAutorRepository : IRepository <Autor>
    {
        // Obtener la relacion de autores con los libros en los cuales han desarrollado
        //el resultado se devolverá de acuerdo a parametros de paginación para no
        //traer toda la tabla de actores a memoria 
     //    IEnumerable<Autor> GetAutoresWithLibros(int pageIndex, int pageSize);



     //   IEnumerable<Autor> GetAutoresByTipoLibro(TipoLibro TipoLibro);

       // IEnumerable<Autor> GetAutoresByCategoria(Categoria Categoria);
    }
}

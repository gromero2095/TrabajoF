using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        

        //**** IMPORTANTE ****
       //Métodos estandar que todas las tablas deben tener
        // Se programan de manera generica no duplicar codigo por cada una.
        
        //C REATES
        //Agrega un registro al repositorio ( SQL SERVER) a la tabla TEntity
        void Add(TEntity entity);
        //Agrega un grupo de un registros al repositorio ( SQL SERVER) a la tabla TEntity
        void AddRange(IEnumerable<TEntity> entities);


        //R EADS
        //Obtiene el Registro con Primary Key = Id de la tabla TEntity
        TEntity Get(int Id);
        // Obiente todos los registros de la tabla TEntity
        IEnumerable<TEntity> GetAll();
        // Obtiene todos los registros de la tabla TEntity que cumplan con la condicion predicate
        //predicate es una expresion lambda que tiene como parametro de entrada TEntity
        // y devolvera una expresion booleana. Si esa expresion es True para un registro,
        // entonces dicho registro se agrega a la lista de registros a devolver a la aplicacion.
        IEnumerator<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //UPDATES
        //Actualiza un registro al repositorio ( SQL SERVER) a la tabla TEntity
        void Update(TEntity entity);
        //Actualiza un grupo de un registros al repositorio ( SQL SERVER) a la tabla TEntity
        void UpdateRange(IEnumerable<TEntity> entities);

        //DELETES
        //Elimina un registro al repositorio ( SQL SERVER) a la tabla TEntity
        void Delete(TEntity entity);
        //Elimina un grupo de registros al repositorio ( SQL SERVER) a la tabla TEntity
        void DeleteRange(IEnumerable<TEntity> entities);

    
    }
}

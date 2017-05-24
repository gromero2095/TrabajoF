using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoF.Entities.IRepositories
{
    /* Debe heredar de IDisposable para que el Garbage Collector
     * Pueda liberar memoria que ya no utilice
         
         */
    public interface IUnityOfWork : IDisposable
    {
        //cada una de las propiedades deben ser de solo lectura
        IAutorRepository Autors { get; }
        ICarritoRepository Carritos { get;  }
        IClienteRepository Clientes { get;  }
        IComprobanteRepository Comprobantes { get;  }
        IEmpleadoRepository Empleados { get; }
        ILibreriaRepository Librerias { get; }
        ILibroRepository Libros { get; }
        ILocalLibreriaRepository LocalLibrerias { get;  }
        INacionalidadRepository Nacionalidads { get; }
        IPagoRepository Pagos { get;  }
        IVentaRepository Ventas { get;  }

        //Método que guardará los cambios en la base de datos.
        int SaveChanges();

        void StateModified(Object entity);


    }
}

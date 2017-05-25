using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities.IRepositories;

namespace TrabajoF.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly TrabajoFinalDbContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public  IAutorRepository Autors { get; private set; }
        public ICarritoRepository Carritos { get; private set; }
        public IClienteRepository Clientes { get; private set; }
        public IComprobanteRepository Comprobantes { get; private set; }
        public IEmpleadoRepository Empleados { get; private set; }
        public ILibreriaRepository Librerias { get; private set; }
        public ILibroRepository Libros { get; private set; }
        public ILocalLibreriaRepository LocalLibrerias { get; private set; }
        public INacionalidadRepository Nacionalidads { get; private set; }
        public IPagoRepository Pagos { get; private set; }
        public IVentaRepository Ventas { get; private set; }

        //Se define el constructor por defecto como privado para que se fuerce a utilizar
        // la propiedad Instance
  
        private UnityOfWork(TrabajoFinalDbContext context)
        {
            // Se crea un unico contexto de base de datos
            // para apuntar todos los repositorios a la misma base de datos
            _Context = context;

            //     _Context = new TrabajoFinalDbContext();

            Autors = new AutorRepository(_Context);
            Carritos = new CarritoRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Comprobantes = new ComprobanteRepository(_Context);
            Empleados = new EmpleadoRepository(_Context);
            Librerias = new LibreriaRepository(_Context);
            Libros = new LibroRepository(_Context);
            LocalLibrerias = new LocalLibreriaRepository(_Context);
            Nacionalidads = new NacionalidadRepository(_Context);
            Pagos = new PagoRepository(_Context);
            Ventas = new VentaRepository(_Context);


        }

        //Implementacion del patron singleton para instanciar la clase UnityOfWork
        // Con este patron se asegura que en cualquier parte del codigo que se quiera
        // instancia la base de datos, se devuelva una unica referencia.

   /*     public static UnityOfWork Instance
        {
            get
            {
                //Variable de control para manejar el acceso concurrente
                // al instanciamiento de la clase UnityOfWork 
              lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();

                }
                return _Instance;
            }

        }
        */

        IAutorRepository IUnityOfWork.Autors => throw new NotImplementedException();

        ICarritoRepository IUnityOfWork.Carritos => throw new NotImplementedException();

        IClienteRepository IUnityOfWork.Clientes => throw new NotImplementedException();

        IComprobanteRepository IUnityOfWork.Comprobantes => throw new NotImplementedException();

        IEmpleadoRepository IUnityOfWork.Empleados => throw new NotImplementedException();

        ILibreriaRepository IUnityOfWork.Librerias => throw new NotImplementedException();

        ILibroRepository IUnityOfWork.Libros => throw new NotImplementedException();

        ILocalLibreriaRepository IUnityOfWork.LocalLibrerias => throw new NotImplementedException();

        INacionalidadRepository IUnityOfWork.Nacionalidads => throw new NotImplementedException();

        IPagoRepository IUnityOfWork.Pagos => throw new NotImplementedException();

        IVentaRepository IUnityOfWork.Ventas => throw new NotImplementedException();

        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

        /*     int IUnityOfWork.SaveChanges()
             {
                 throw new NotImplementedException();
             }

             void IUnityOfWork.StateModified(object entity)
             {
                 throw new NotImplementedException();
             }

             void IDisposable.Dispose()
             {
                 throw new NotImplementedException();
             }
             */
    }
}

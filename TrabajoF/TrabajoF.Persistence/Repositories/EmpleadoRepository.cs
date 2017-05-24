﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoF.Entities;
using TrabajoF.Entities.IRepositories;

namespace TrabajoF.Persistence.Repositories
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        private readonly TrabajoFDbContext _Context;

        public EmpleadoRepository(TrabajoFDbContext context)
        {
            _Context = context;
        }
        private EmpleadoRepository()
        {

        }

        IEnumerable<Empleado> IEmpleadoRepository.GetEmpleadosByTipoEmpleado(TipoEmpleado TipoEmpleado)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Empleado> IEmpleadoRepository.GetEmpleadossWithLocalLibreria(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}

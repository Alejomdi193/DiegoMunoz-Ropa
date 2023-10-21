using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interface;

namespace Dominio.Interface
{
    public interface IUnitOfWork
    {

        IRol Roles { get; }
        IUsuario Usuarios { get; }
        
        ICargo Cargos {get;}
        ICliente Cliente {get;}

        IColorr Colorr {get;}

        IDepartamento Departamento {get; set;}

        IDetalleOrden DetalleOrden{get;}

        Task<int> SaveAsync();
    }
}
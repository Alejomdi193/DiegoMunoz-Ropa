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
        Task<int> SaveAsync();
    }
}
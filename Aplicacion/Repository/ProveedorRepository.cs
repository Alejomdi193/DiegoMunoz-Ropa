using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Persistencia;
using Dominio.Interface;

namespace Aplicacion.Repository
{
    public class ProveedorRepository : GenericRepository<Proveedor> , IProveedor
    {
        private readonly SkeletonContext _context;

        public ProveedorRepository(SkeletonContext context) : base(context)
        {
            _context = context;
        }
    }
}
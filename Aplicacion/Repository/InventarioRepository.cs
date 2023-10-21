using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Interface;
using Persistencia;
namespace Aplicacion.Repository
{
    public class InventarioRepository : GenericRepository<Inventario> , IInventario 
    {
        private readonly SkeletonContext _context;

        public InventarioRepository(SkeletonContext context) : base(context)
        {
            _context = context;
        }
    }
}
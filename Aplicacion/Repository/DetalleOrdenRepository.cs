using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Interface;
using Persistencia;

namespace Aplicacion.Repository
{
    public class DetalleOrdenRepository : GenericRepository<DetalleOrden> , IDetalleOrden
    {
        private readonly SkeletonContext _context;

        public DetalleOrdenRepository(SkeletonContext context) : base(context)
        {
            _context = context;
        }
    }
}
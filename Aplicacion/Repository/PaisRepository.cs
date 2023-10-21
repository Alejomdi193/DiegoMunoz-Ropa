using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Interface;
using Persistencia;

namespace Aplicacion.Repository
{
    public class PaisRepository : GenericRepository<Pais> ,IPais
    {
        private readonly SkeletonContext _context;

        public PaisRepository(SkeletonContext context) : base(context)
        {
            _context = context;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Interface;
using Persistencia;

namespace Aplicacion.Repository
{
    public class GeneroRepository : GenericRepository<Genero> ,IGenero
    {
        private readonly SkeletonContext _context;

        public GeneroRepository(SkeletonContext context) : base(context)
        {
            _context = context;
        }
    }
}
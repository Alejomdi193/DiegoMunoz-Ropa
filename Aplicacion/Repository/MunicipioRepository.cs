using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;
using Dominio.Interface;
using System.Threading.Tasks;
using Persistencia;

namespace Aplicacion.Repository
{
    public class MunicipioRepository : GenericRepository<Municipio>, IMunicipio
    {
        private readonly SkeletonContext _context;

        public MunicipioRepository(SkeletonContext context) : base(context)
        {
            _context = context;
        }
    }
}
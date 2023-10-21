using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Interface;
using Persistencia;
namespace Aplicacion.Repository
{
    public class DepartamentoRepository : GenericRepository<Departamento> , IDepartamento
    {
        private readonly SkeletonContext _context;

        public DepartamentoRepository(SkeletonContext context) : base(context)
        {
            _context = context;
        }
    }
}
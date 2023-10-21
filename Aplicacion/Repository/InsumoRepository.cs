using Dominio.Entidades;
using Dominio.Interface;
using Persistencia;

namespace Aplicacion.Repository
{
    public class InsumoRepository : GenericRepository<Insumo> , IInsumo
    {
        private readonly SkeletonContext _context;

        public InsumoRepository(SkeletonContext context) : base(context)
        {
            _context = context;
        }
    }
}
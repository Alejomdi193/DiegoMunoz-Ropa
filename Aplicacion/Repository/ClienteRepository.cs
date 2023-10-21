using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Interface;
using Persistencia;
namespace Aplicacion.Repository
{
    public class ClienteRepository : GenericRepository<Cliente> , ICliente
    {
        private readonly SkeletonContext _context;

        public ClienteRepository(SkeletonContext context) : base(context)
        {
            _context = context;
        }
    }
}
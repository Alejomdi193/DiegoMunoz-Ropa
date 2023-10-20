using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Interface;
using Persistencia;

namespace Aplicacion.Repository
{
    public class RolRepository : GenericRepository<Rol> , IRol
    {
        private readonly SkeletonContext context;
        public RolRepository(SkeletonContext context) : base(context)
        {
            this.context = context;
        }
    }
}
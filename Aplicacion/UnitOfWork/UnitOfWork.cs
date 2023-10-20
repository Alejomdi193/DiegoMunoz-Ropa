using Aplicacion.Repository;
using Dominio.Entidades;
using Dominio.Interface;
using Persistencia;

namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private readonly SkeletonContext context;
        public UnitOfWork(SkeletonContext _context)
        {
            context = _context;
        }
       
        public IRol _roles;
        public IUsuario _usuarios;

        public IRol Roles 
        {
            get{
                if(_roles == null)
                {
                    _roles = new RolRepository(context);
                }
                return _roles;
            }
        }

        public IUsuario Usuarios
        {
            get{
                if(_usuarios == null)
                {
                    _usuarios = new UsuarioRepository(context);
                }
                return _usuarios;

            }
        }
        

        public void Dispose()
        {
         context.Dispose();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
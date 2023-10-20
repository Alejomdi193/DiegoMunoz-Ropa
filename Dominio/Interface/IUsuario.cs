using Dominio.Entidades;
using Dominio.Interface;

namespace Dominio.Interface
{
    public interface IUsuario : IGeneric<Usuario>
    {
        Task<Usuario> GetByUserNameAsync(string refreshToken);
        Task<Usuario> GetByRefreshTokenAsync(string username);

        
    }
}
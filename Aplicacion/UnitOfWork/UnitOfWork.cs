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

        public ICargo _cargo;
        public ICliente _cliente;
        public IColorr _colorr;
        public IDepartamento _departamento;
        public IDetalleOrden _detalleOrden;
        public IDetalleVenta _detalleVenta;
        public IEmpleado _empleado;
        public IEmpresa _empresa;
        public IEstado _estado;
        public IFormaPago _formaPago;
        public IGenero _genero;
        public IInsumo _insumo;
        public IInventario _inventario;
        public IMunicipio _municipio;
        public IOrden _orden;
        public IPais _pais;
        public IPrenda _prenda;
        public IProveedor _proveedor;
        public ITalla _talla;
        public ITipoEstado _tipoEstado;
        public ITipoPersona _tipoPersona;
        public ITipoProteccion _tipoProteccion;
        public IVenta _venta;

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


        public ICargo Cargos
        {
            get{
                if(_cargo == null)
                {
                    _cargo = new CargoRepository(context);
                }
                return _cargo;

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
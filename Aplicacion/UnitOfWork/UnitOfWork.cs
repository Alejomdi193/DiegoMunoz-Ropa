using Aplicacion.Repository;
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


        public ICliente Clientes
        {
            get{
                if(
                    _cliente == null)
                {
                    
                    _cliente = new ClienteRepository(context);
                }
                return 
                _cliente;

            }
        }

        public IColorr Colorr
        {
            get{
                if(
                    _colorr == null)
                {
                    
                    _colorr = new ColorrRepository(context);
                }
                return 
                _colorr;

            }
        }


        public IDepartamento Departamento
        {
            get{
                if(
                    _departamento == null)
                {
                    
                    _departamento = new DepartamentoRepository(context);
                }
                return 
                _departamento;

            }
        }


        public IDetalleOrden DetalleOrden
        {
            get{
                if(
                    _detalleOrden == null)
                {
                    
                    _detalleOrden = new DetalleOrdenRepository(context);
                }
                return 
                _detalleOrden;

            }
        }

        public IDetalleVenta DetalleVenta
        {
            get{
                if(
                    _detalleVenta == null)
                {
                    
                    _detalleVenta = new DetalleVentaRepository(context);
                }
                return 
                _detalleVenta;

            }
        }


        public IEmpleado Empleado
        {
            get{
                if(
                    _empleado == null)
                {
                    
                    _empleado = new EmpleadoRepository(context);
                }
                return 
                _empleado;

            }
        }

        public IEstado Estado
        {
            get{
                if(
                    _estado == null)
                {
                    
                    _estado = new EstadoRepository(context);
                }
                return 
                _estado;

            }
        }

        public IFormaPago FormaPago
        {
            get{
                if(
                    _formaPago == null)
                {
                    
                    _formaPago = new FormaPagoRepository(context);
                }
                return 
                _formaPago;

            }
        }


        public IGenero Genero
        {
            get{
                if(
                    _genero == null)
                {
                    
                    _genero = new GeneroRepository(context);
                }
                return 
                _genero;

            }
        }


        public IInsumo Insumo
        {
            get{
                if(
                    _insumo == null)
                {
                    
                    _insumo = new InsumoRepository(context);
                }
                return 
                _insumo;

            }
        }

        public IInventario Inventario
        {
            get{
                if(
                    _inventario == null)
                {
                    
                    _inventario = new InventarioRepository(context);
                }
                return 
                _inventario;

            }
        }


        public IMunicipio Municipio
        {
            get{
                if(
                    _municipio == null)
                {
                    
                    _municipio = new MunicipioRepository(context);
                }
                return 
                _municipio;

            }
        }

        public IOrden Orden
        {
            get{
                if(
                    _orden == null)
                {
                    
                    _orden = new OrdenRepository(context);
                }
                return 
                _orden;

            }
        }

        public IPais Pais
        {
            get{
                if(
                   _pais == null)
                {
                    
                   _pais = new PaisRepository(context);
                }
                return 
               _pais;

            }
        }

        public IPrenda Prenda
        {
            get{
                if(
                  _prenda == null)
                {
                    
                  _prenda = new PrendaRepository(context);
                }
                return 
              _prenda;

            }
        }

        public IProveedor Proveedor
        {
            get{
                if(
                  _proveedor == null)
                {
                    
                  _proveedor = new ProveedorRepository(context);
                }
                return 
              _proveedor;

            }
        }


        public ITalla Talla
        {
            get{
                if(
                  _talla == null)
                {
                    
                  _talla = new TallaRepository(context);
                }
                return 
              _talla;

            }
        }

        public ITipoEstado TipoEstado
        {
            get{
                if(
                  _tipoEstado == null)
                {
                    
                  _tipoEstado = new TipoEstadoRepository(context);
                }
                return 
              _tipoEstado;

            }
        }


        public ITipoPersona TipoPersona
        {
            get{
                if(
                  _tipoPersona == null)
                {
                    
                  _tipoPersona = new TipoPersonaRepository(context);
                }
                return 
              _tipoPersona;

            }
        }

        public ITipoProteccion TipoProteccion
        {
            get{
                if(
                  _tipoProteccion == null)
                {
                    
                  _tipoProteccion = new TipoProteccionRepository(context);
                }
                return 
              _tipoProteccion;

            }
        }

        public IVenta Venta
        {
            get{
                if(
                  _venta == null)
                {
                    
                  _venta = new VentaRepository(context);
                }
                return _venta;

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
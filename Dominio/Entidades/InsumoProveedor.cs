using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class InsumoProveedor
    {
        

        public int IdInsumoFk {get; set;}
        public Insumo Insumo {get; set;}
        public int IdProoveedorFk {get; set;}
        public Proveedor Proveedor {get; set;}

        public ICollection<Insumo> Insumos {get; set;} = new HashSet<Insumo>();
        public ICollection<InsumoProveedor> InsumoProveedores {get; set;}
    }
}
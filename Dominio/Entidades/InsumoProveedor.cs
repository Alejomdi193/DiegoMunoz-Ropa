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
        public Proveedor Proveedores {get; set;}
    }
}
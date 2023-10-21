using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class InsumoProveedorDto
    {
        public int IdInsumoFk {get; set;}
        public InsumoDto Insumo {get; set;}
        public int IdProoveedorFk {get; set;}
        public ProveedorDto Proveedor {get; set;}
    }
}
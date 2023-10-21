using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class InsumoDto
    {
         public string Nombre{get; set;}
        public int ValorUnit {get; set;}
        public int StockMin {get; set;}
        public int StockMax {get; set;}
        public ICollection<PrendaDto> Prendas {get; set;}
        public ICollection<InsumoPrendaDto> InsumoPrendas{get; set;}
        public ICollection<ProveedorDto> Proveedores {get; set;}
        public ICollection<InsumoProveedorDto> InsumoProveedores {get; set;}
    }
}
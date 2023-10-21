using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class InventarioDto
    {
        public int CodInv {get; set;}
        public int ValorVtaCop{get; set;}
        public int ValorVtaUsd {get; set;}
        public int IdPrendaFk {get; set;}
        public PrendaDto Prenda {get; set;}
         public ICollection<DetalleVentaDto> DetalleVentas{get; set;}
    }
}
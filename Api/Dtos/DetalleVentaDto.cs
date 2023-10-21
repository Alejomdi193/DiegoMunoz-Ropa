using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class DetalleVentaDto
    {
        public int Cantidad{get; set;}
        public int ValorUnit {get; set;}
        public int IdVentaFk {get; set;}
        public VentaDto Venta {get; set;}
        public int IdInventarioFk {get; set;}
        public InventarioDto Inventario {get; set;}
        public int IdTallaFk {get; set;}
        public TallaDto Talla {get; set;}
    }
}
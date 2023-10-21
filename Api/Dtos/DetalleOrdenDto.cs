using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class DetalleOrdenDto
    {
         public int CantidadProducir {get; set;}
        public int CantidadProducida {get; set;}
        public int IdOrdenFk {get; set;}
        public OrdenDto Orden {get; set;}
        public int IdPrendaFk {get; set;}
        public PrendaDto Prenda {get; set;}
        public int IdColorFk {get; set;}
        public ColorrDto Colorr {get; set;}
        public int IdEstadoFk {get; set;}
        public EstadoDto Estado {get; set;}
        public int IdInventarioFk {get; set;}
        public InventarioDto Inventario {get; set;} 
    }
}
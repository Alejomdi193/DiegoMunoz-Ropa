using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class EstadoDto
    {
        public string Descripcion {get; set;}
        public int IdTipoEstadoFk{get; set;}
        public TipoEstadoDto TipoEstado{get; set;}
        public ICollection<PrendaDto> Prendas {get; set;}
        public ICollection<DetalleOrdenDto> DetalleOrdenes {get; set;} 
        public ICollection<OrdenDto> Ordenes {get; set;}
        
    }
}
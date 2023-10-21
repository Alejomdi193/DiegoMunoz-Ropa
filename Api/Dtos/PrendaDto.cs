using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class PrendaDto
    {
          public int IdPrenda {get; set;}
        public string Nombre {get; set;}
        public int ValorUnitCop {get; set;}
        public int ValorUnitUsd {get; set;}
        public int IdEstadoFk {get; set;}
        public EstadoDto Estado {get; set;}
        public int IdTipoProteccionFk {get; set;}
        public TipoProteccionDto TipoProteccion {get; set;}
        public int IdGeneroFk {get; set;}
        public GeneroDto Genero {get; set;}
         public ICollection<InsumoPrendaDto> InsumoPrendas {get; set;}
        public ICollection<DetalleOrdenDto> DetalleOrdenes {get; set;}
        public ICollection<InventarioDto> Inventarios {get; set;}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class ClienteDto
    {
         public int IdCliente {get; set;}
        public string Nombre {get; set;}
        public DateTime FechaRegistro {get; set;}
        public int IdTipoPersonaFk {get; set;}
        public TipoPersonaDto TipoPersona {get; set;}
        public int IdMunicipioFk {get; set;}
        public MunicipioDto Municipio{get; set;}
        public ICollection<OrdenDto> Ordenes {get; set;}
        public ICollection<VentaDto> Ventas{get; set;}
    }
}
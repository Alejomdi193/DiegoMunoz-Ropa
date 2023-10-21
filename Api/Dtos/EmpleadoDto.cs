using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class EmpleadoDto
    {
        public int IdEmpleadoFk {get; set;}
        public string Nombre {get; set;}
        public DateTime FechaIngreso {get; set;}
        public int IdCargoFk {get; set;}
        public CargoDto Cargo {get; set;}
        public int IdMunicipioFk {get; set;}
        public MunicipioDto Municipio {get; set;}
        public ICollection<OrdenDto> Ordenes{get; set;}
        public ICollection<VentaDto> Ventas {get; set;}
    }
}
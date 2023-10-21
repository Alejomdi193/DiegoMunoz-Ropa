using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class OrdenDto
    {
         public DateTime Fecha {get; set;}
        public int IdEmpleadoFk {get; set;}
        public EmpleadoDto Empleado {get; set;}
        public int IdClienteFk {get; set;}
        public ClienteDto Cliente {get; set;}
        public int IdEstadoFk {get; set;}
        public EstadoDto Estado {get; set;}
    }
}
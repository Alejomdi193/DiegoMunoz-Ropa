using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class TipoEstadoDto
    {
         public string Descripcion {get; set;}
        public ICollection<EstadoDto> Estados {get; set;}
    }
}
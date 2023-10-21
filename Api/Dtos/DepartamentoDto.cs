using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class DepartamentoDto
    {
        public string Nombre {get; set;}
        public int IdPaisFk {get; set;}
        public PaisDto Pais {get; set;}

         public ICollection<MunicipioDto> Municipios {get; set;}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class EmpresaDto
    {
         public int Nit {get; set;}
        public string RazonSocial {get; set;}
        public string RepresentanteLegal {get; set;}
        public DateTime FechaCreacion {get; set;}
        public int IdMunicipioFk {get; set;}
        public MunicipioDto Municipio {get; set;}
    }
}
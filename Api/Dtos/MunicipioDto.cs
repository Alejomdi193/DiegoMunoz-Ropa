using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class MunicipioDto
    {
        public string Nombre {get; set;}
        public int IdDepartamentoFk {get; set;} 
        public DepartamentoDto Departamento {get; set;}  
        public ICollection<EmpleadoDto> Empleados{get; set;}
        public ICollection<ClienteDto> Clientes {get; set;}
        public ICollection<EmpresaDto> Empresas {get; set;}
        public ICollection<ProveedorDto> Proveedores {get; set;}
    }
}
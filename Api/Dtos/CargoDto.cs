using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Api.Dtos
{
    public class CargoDto
    {
        public string Descripcion {get; set;}
        public int SueldoBase {get; set;}
        public ICollection<Empleado> Empleados{get; set;}
    }
}
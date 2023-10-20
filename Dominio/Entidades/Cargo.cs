using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Cargo : BaseEntity
    {
        public string Descripcion{get; set;}
        public int SueldoBase{get; set;}
        public ICollection<Empleado> Empleados{get; set;}
    }
}
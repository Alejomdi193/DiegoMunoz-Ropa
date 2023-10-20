using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class TipoPersona : BaseEntity
    {
        public string Descripcion {get; set;}
        public ICollection<Cliente> Clientes {get; set;}
        public ICollection<Proveedor> Proveedores {get; set;}
    }
}
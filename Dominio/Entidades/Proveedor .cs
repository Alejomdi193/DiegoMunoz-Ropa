using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Proveedor : BaseEntity
    {
        public int NitProveedor {get; set;}
        public string Nombre {get; set;}
        public int IdTipoPersonaFk {get; set;}
        public TipoPersona TipoPersona {get; set;}
        public int IdMunicipioFk {get; set;}
        public Municipio Municipio {get; set;} 

        public ICollection<Insumo> Insumo{get; set;}

         public ICollection<InsumoProveedor> InsumoProveedores {get; set;}
    }
}
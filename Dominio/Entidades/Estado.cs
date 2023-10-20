using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Estado : BaseEntity
    {
        public string Descripcion {get; set;}
        public int IdTipoEstadoFk{get; set;}
        public TipoEstado TipoEstado{get; set;}
        public ICollection<Prenda> Prendas {get; set;}
        public ICollection<DetalleOrden> DetalleOrdenes {get; set;} 
        public ICollection<Orden> Ordenes {get; set;}
        
        
    }
}
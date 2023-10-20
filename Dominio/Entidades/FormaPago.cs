using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class FormaPago : BaseEntity
    {
        public string Descripcion{get; set;}
        public ICollection<Venta> Ventas{get; set;}
    }
}
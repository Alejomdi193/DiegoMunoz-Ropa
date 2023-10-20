using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class DetalleVenta : BaseEntity
    {   
        public int Cantidad{get; set;}
        public int ValorUnit {get; set;}
        public int IdVentaFk {get; set;}
        public Venta Venta {get; set;}
        public int IdInventarioFk {get; set;}
        public Inventario Inventario {get; set;}
        public int IdTallaFk {get; set;}
        public Talla Talla {get; set;}


        
    }
}
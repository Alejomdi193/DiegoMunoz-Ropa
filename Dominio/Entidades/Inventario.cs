using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Inventario : BaseEntity
    {
        public int CodInv {get; set;}
        public int ValorVtaCop{get; set;}
        public int ValorVtaUsd {get; set;}
        public int IdPrendaFk {get; set;}
        public Prenda Prenda {get; set;}
        public ICollection<DetalleVenta> DetalleVentas{get; set;}
        public ICollection<InventarioTalla> InventarioTallas {get; set;}


    }
}
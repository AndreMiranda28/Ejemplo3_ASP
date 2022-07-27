using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Domain.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public decimal Stock { get; set; }
        public decimal StockMinimo { get; set; }
        public decimal PrecioPorMenor { get; set; }
        public decimal PrecioPorMayor { get; set; }


    }
}

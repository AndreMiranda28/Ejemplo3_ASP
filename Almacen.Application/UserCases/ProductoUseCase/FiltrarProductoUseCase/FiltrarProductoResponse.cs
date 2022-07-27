using Almacen.Application.Common.Mappings;
using Almacen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.ProductoUseCase.FiltrarProductoUseCase
{
    public class FiltrarProductoResponse : IMapFrom<Producto, FiltrarProductoResponse>
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string IdCategoria { get; set; }
        public string IdMarca { get; set; }
        public string IdModelo { get; set; }
        public string Stock { get; set; }
        public string StockMinimo { get; set; }
        public string PrecioPorMenor { get; set; }
        public string PrecioPorMayor { get; set; }

    }
}

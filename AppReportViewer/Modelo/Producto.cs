using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppReportViewer.Modelo
{
    public class Producto
    {
		public int Id { get; set; }
		public string NombreProducto { get; set; }
		public decimal Precio { get; set; }
		public int Stock { get; set; }
		public string NombreCategoria { get; set; }
	}
}
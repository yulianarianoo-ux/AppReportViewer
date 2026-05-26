using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppReportViewer.Datos;
using AppReportViewer.Modelo;

namespace AppReportViewer.Logica
{
    public class ProductoL
    {
		public List<Producto> MtListaProductos()
		{
			ProductoD oProductoD = new ProductoD();
			return oProductoD.MtListaProductos();
		}
	}
}
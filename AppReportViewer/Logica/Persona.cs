using AppReportViewer.Datos;
using AppReportViewer.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppReportViewer.Logica
{
    public class Persona
    {
        public List<Producto> MtListaProductos()
        {
            ProductoD oProductoD = new ProductoD();
            return oProductoD.MtListaProductos();
        }
    }
}
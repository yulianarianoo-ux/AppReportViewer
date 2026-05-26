using AppReportViewer.Logica;
using AppReportViewer.Modelo;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppReportViewer.Vista
{
    public partial class Reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProductoL oProductoL = new ProductoL();
                List<Producto> lista = oProductoL.MtListaProductos();

                ReportViewer1.LocalReport.ReportPath = Server.MapPath("ReporteProductos.rdlc");
                ReportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("Reporte", lista);

                ReportViewer1.LocalReport.DataSources.Add(rds);
                ReportViewer1.LocalReport.Refresh();
            }
        }
    }
}
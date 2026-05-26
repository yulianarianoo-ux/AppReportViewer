using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppReportViewer.Datos
{
    public class ConexionDB
    {
		private static readonly string cadena = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

		public static SqlConnection AbrirConexion()
		{
			if (string.IsNullOrWhiteSpace(cadena))
			{
				throw new Exception("La cadena de conexión no está configurada correctamente.");
			}
			return new SqlConnection(cadena);
		}
	}
}
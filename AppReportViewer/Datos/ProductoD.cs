using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AppReportViewer.Modelo;

namespace AppReportViewer.Datos
{
    public class ProductoD
    {
		public List<Producto> MtListaProductos()
		{
			List<Producto> listaProductos = new List<Producto>();

			using (SqlConnection cn = ConexionDB.AbrirConexion())
			{
				cn.Open();

				string consulta = @"SELECT p.IdProducto, p.NombreProducto, p.Precio, p.Stock, c.NombreCategoria 
                             FROM Productos p 
                             INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria";

				using (SqlCommand cmd = new SqlCommand(consulta, cn))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							listaProductos.Add(new Producto
							{
								Id = Convert.ToInt32(dr["IdProducto"]),
								NombreProducto = dr["NombreProducto"].ToString(),
								Precio = Convert.ToDecimal(dr["Precio"]),
								Stock = Convert.ToInt32(dr["Stock"]),
								NombreCategoria = dr["NombreCategoria"].ToString()
							});

						}
					}
				}

			}
			return listaProductos;
		}
	}
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class PRODUCTO
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private float precio;

		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		public static List<PRODUCTO> Listar()
		{
            List<PRODUCTO> productos = new List<PRODUCTO>();
           ACCESO acceso = new ACCESO();
			acceso.Abrir();
			SqlDataReader reader = acceso.Leer("PRODUCTO_LISTAR");
			while (reader.Read())
			{
				PRODUCTO producto = new PRODUCTO();
				producto.id = int.Parse(reader["ID_PRODUCTO"].ToString());	
				producto.descripcion = reader["NOMBRE"].ToString();
                producto.Precio = float.Parse(reader["PRECIO"].ToString());
				productos.Add(producto);	
            }
			reader.Close();
			acceso.Cerrar();
			return productos;
		}

	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class ITEM
    {
		private PRODUCTO producto;

		public PRODUCTO Producto
		{
			get { return producto; }
			set { producto = value; }
		}

		private int cantidad;

		public int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}


	}
}
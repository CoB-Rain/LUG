using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class TABLERO
    {
		private int filas;

		public int Filas
		{
			get { return filas; }
			set { filas = value; }
		}

		private int columnas;

		public int Columnas
		{
			get { return columnas; }
			set { columnas = value; }
		}


		private List<FICHA> fichas = new List<FICHA>();

		public List<FICHA> Fichas
		{
			get { return fichas; }
		
		}


	}
}
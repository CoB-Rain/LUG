using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEMOTEST
{
    public class CASILLERO
    {

		private int _x;

		public int X
		{
			get { return _x; }
			set { _x = value; }
		}

		private int _y;

		public int Y
		{
			get { return _y; }
			set { _y = value; }
		}

		private int _ancho;

		public int Ancho
		{
			get { return _ancho; }
			set { _ancho = value; }
		}

		private FICHA _ficha;

		public FICHA Ficha
		{
			get { return _ficha; }
			set { _ficha = value; }
		}



	}
}
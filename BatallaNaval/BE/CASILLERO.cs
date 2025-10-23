using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class CASILLERO
    {
		private ESTADO_CASILLERO _estado;

		public ESTADO_CASILLERO Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

		private COORDENADA _posicion;

		public COORDENADA Posicion
		{
			get { return _posicion; }
		}

		private COORDENADA _tamaño;

		public COORDENADA Tamaño
		{
			get { return _tamaño; }
		}
	}
}
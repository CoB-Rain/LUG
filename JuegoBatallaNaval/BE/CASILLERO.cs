using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class CASILLERO
    {
        public CASILLERO()
        {
            _posicion = new COORDENADA();
			_tamaño = new COORDENADA();
            _estado = ESTADO_CASILLERO.Tocado;
        }

        private COORDENADA _posicion;

		public COORDENADA Posicion
		{
			get { return _posicion; }
			set { _posicion = value; }
		}

		private  COORDENADA _tamaño = new COORDENADA();

		public COORDENADA Tamaño
		{
			get { return _tamaño; }
			set { _tamaño = value; }
		}

		private ESTADO_CASILLERO _estado;

		public ESTADO_CASILLERO Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}
	}
}
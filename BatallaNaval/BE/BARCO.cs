using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public abstract class BARCO
    {
        protected BARCO()
        {
			_estado = ESTADO_BARCO.flotando;
        }

        protected string _imagen;

        public string Imagen
        {
            get { return _imagen; }
        }

		private ESTADO_BARCO _estado;

		public ESTADO_BARCO Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

		private List<CASILLERO> _casillerosOcupados;

		public List<CASILLERO> CasillerosOcupados
		{
			get { return _casillerosOcupados; }
			set { _casillerosOcupados = value; }
		}
	}
}
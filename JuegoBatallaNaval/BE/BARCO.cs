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
            _casillerosOcupados = new List<CASILLERO>();
            _estado = ESTADO_BARCO.Flotando;
        }

        protected List<CASILLERO> _casillerosOcupados;

		public List<CASILLERO> CasillerosOcupados
		{
			get { return _casillerosOcupados; }
			set { _casillerosOcupados = value; }
		}

		protected ESTADO_BARCO _estado;

		public ESTADO_BARCO Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

		protected string _imagen;

		public string Imagen
		{
			get { return _imagen; }
			set { _imagen = value; }
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class BARCO
    {
        public BARCO()
        {
            _casillerosOcupados = new List<CASILLERO>();
            _estado = ESTADO_BARCO.Flotando;
        }

        public List<CASILLERO> _casillerosOcupados;

		public List<CASILLERO> CasillerosOcupados
		{
			get { return _casillerosOcupados; }
			set { _casillerosOcupados = value; }
		}

		public ESTADO_BARCO _estado;

		public ESTADO_BARCO Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

		private TipoBarco _tipo;

		public TipoBarco Tipo
		{
			get { return _tipo; }
			set { _tipo = value; }
		}

		public string _imagen;

		public string Imagen
		{
			get { return _imagen; }
			set { _imagen = value; }
		}
	}
}
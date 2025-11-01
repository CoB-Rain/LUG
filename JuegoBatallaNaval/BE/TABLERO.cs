using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class TABLERO
    {
        public TABLERO()
        {
            _casilleros = new List<CASILLERO>();
        }

        private List<CASILLERO> _casilleros;

		public List<CASILLERO> Casilleros
		{
			get { return _casilleros; }
			set { _casilleros = value; }
		}
	}
}
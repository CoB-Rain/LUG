using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class JUGADOR : USUARIO
    {
		private int _idj;

		public int ID_J
		{
			get { return _idj; }
			set { _idj = value; }
		}

		private int _partidasGanadas;

		public int PartidasGanadas
		{
			get { return _partidasGanadas; }
		}

		private int _partidasPerdidas;

		public int PartidasPerdidas
		{
			get { return _partidasPerdidas; }
		}

		private int _partidasEmpatadas;

		public int PartidasEmpatadas
		{
			get { return _partidasEmpatadas; }
		}
	}
}
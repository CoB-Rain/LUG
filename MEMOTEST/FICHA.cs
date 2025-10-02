using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEMOTEST
{
    public class FICHA : ICloneable
    {

		private int _numero;

		public int Numero
		{
			get { return _numero; }
			set { _numero = value; }
		}

		private string _imagen;

		public string Imagen
		{
			get { return _imagen; }
			set { _imagen = value; }
		}

		private ESTADO _estado = ESTADO.Cubierto;

		public ESTADO Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

        public object Clone()
        {
			return this.MemberwiseClone();
		}
    }
}
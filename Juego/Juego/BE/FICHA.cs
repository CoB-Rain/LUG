using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class FICHA
    {

		public FICHA() 
		{
			estado = Estado.Oculto;
		}

		private string imagen;

		public string Imagen
		{
			get { return imagen; }
			set { imagen = value; }
		}

		private Estado Estado;

		public Estado estado
		{
			get { return Estado; }
			set { Estado = value; }
		}
		 
		private COORDENADA posicion = new COORDENADA();

		public COORDENADA Posicion
		{
			get { return posicion; }
			
		}

        private static COORDENADA tamaño = new COORDENADA();

        public static COORDENADA Tamaño
        {
            get { return tamaño; }

        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MEMOTEST
{
    public class TABLERO
    {
		public event delEnviarCasillero EnviarCasillero;

		private List<CASILLERO> _casilleros;

		public List<CASILLERO> Casilleros
		{
			get { return _casilleros; }
		}

		public void CrearTablero()
		{
			_casilleros = new List<CASILLERO>();
			List<FICHA> fichas = new List<FICHA>();

			for (int i = 0; i < 4; i++)
			{
				FICHA ficha = new FICHA();
				ficha.Numero = i;
				switch(i)
				{
					case 0:
						{
							ficha.Imagen = @"IMG\DIBU.jpg";
							break;
						}
					case 1:
						{
                            ficha.Imagen = "IMG\\MESSI.jpg";
                            break;
						}
					case 2:
						{
                            ficha.Imagen = @"IMG\DIMARIA.jpg";
                            break;
						}
					case 3:
						{
                            ficha.Imagen = @"IMG\WANDA.jpg";
                            break;
						}
				}


				fichas.Add(ficha);
				fichas.Add(ficha.Clone() as FICHA);
                fichas.Add(ficha.Clone() as FICHA);
                fichas.Add(ficha.Clone() as FICHA);
            }

            for (int fila = 0; fila < 4; fila++)
			{
				for (int columma = 0; columma < 4; columma++)
				{
					CASILLERO casillero = new CASILLERO();
					casillero.X = columma;
					casillero.Y = fila;
					casillero.Ancho = 150;

					int indice = JUEGO.rnd.Next(0, fichas.Count);
					casillero.Ficha = fichas[indice];
					fichas.Remove(casillero.Ficha);

					this.EnviarCasillero(casillero);
					this._casilleros.Add(casillero);
				}
			}
		}
	}
}
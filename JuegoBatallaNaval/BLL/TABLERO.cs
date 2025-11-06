using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class TABLERO
    {
        //cantidad -> maximo de fichas por fila/columna
        //dimension -> espacio que va a ocupar en el formulario
        public BE.TABLERO CrearTablero(int cantidad, int dimension)
        {
            BE.TABLERO tablero = new BE.TABLERO();

            for (int fila = 0; fila < cantidad; fila++)
            {
                for (int columna = 0; columna < cantidad; columna++)
                {
                    BE.CASILLERO casillero = new BE.CASILLERO();
                    casillero.Tamaño.X = dimension;
                    casillero.Tamaño.Y = dimension;
                    casillero.Posicion.X = columna * (casillero.Tamaño.X + 1);
                    casillero.Posicion.Y = fila * (casillero.Tamaño.Y + 1);
                    tablero.Casilleros.Add(casillero);
                }
            }
            return tablero;
        }
    }
}
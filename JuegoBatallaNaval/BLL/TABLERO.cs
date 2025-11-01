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
            BE.CASILLERO.Tamaño.X = dimension;
            BE.CASILLERO.Tamaño.Y = dimension;
            BE.TABLERO tablero = new BE.TABLERO();

            for (int fila = 0; fila < cantidad; fila++)
            {
                for (int columna = 0; columna < cantidad; columna++)
                {
                    BE.CASILLERO casillero = new BE.CASILLERO();
                    casillero.Posicion.X = columna * (CASILLERO.Tamaño.X + 10);
                    casillero.Posicion.Y = fila * (CASILLERO.Tamaño.Y + 10);
                    tablero.Casilleros.Add(casillero);
                }
            }
            return tablero;
        }
    }
}
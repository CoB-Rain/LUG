using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class PARTIDA
    {
        public event delEnviarCasillero EnviarCasillero;
        public event delEnviarBarco EnviarBarco;
        public event delInformar Agua;
        public event delInformar Tocado;
        public event delInformar Hundir;
        public event delInformar Ganar;
        public event delInformar Perder;
        public event delInformar Empatar;

        public PARTIDA()
        {
            _estado = EstadoPartida.NoIniciada;
        }

        private EstadoPartida _estado;

        public EstadoPartida Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public void IniciarPartida(int cantidad, int dimensiones)
        {
            BLL.JUEGO juego = new BLL.JUEGO();
            juego.IniciarJuego(cantidad, dimensiones);
            foreach (BE.CASILLERO casillero in juego.tablero.Casilleros)
            {
                EnviarCasillero(casillero);
            }
            foreach (BE.BARCO barco in juego.barcos)
            {
                EnviarBarco(barco);
            }
        }
    }
}
using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmJuego : Form
    {
        BLL.JUEGO juego;
        public FrmJuego()
        {
            InitializeComponent();
        }

        private void FrmJuego_Load(object sender, EventArgs e)
        {

        }

        private void FrmJuego_Shown(object sender, EventArgs e)
        {
            juego = new BLL.JUEGO();
            juego.EnviarCasillero += Juego_EnviarTablero1;
            juego.EnviarCasillero += Juego_EnviarTablero2;
            juego.IniciarJuego(15, 25);
        }

        private void Juego_EnviarTablero1(CASILLERO casillero)
        {
            miCasillero cas = new miCasillero();
            cas.Location = new Point(casillero.Posicion.X + 1000, casillero.Posicion.Y + 500);
            cas.Size = new Size(casillero.Tamaño.X, casillero.Tamaño.Y);
            cas.Casillero = casillero;
            this.Controls.Add(cas);
        }

        private void Juego_EnviarTablero2(CASILLERO casillero)
        {
            miCasillero cas = new miCasillero();
            cas.Location = new Point(casillero.Posicion.X + 2000, casillero.Posicion.Y + 500);
            cas.Size = new Size(casillero.Tamaño.X, casillero.Tamaño.Y);
            cas.Casillero = casillero;
            this.Controls.Add(cas);
        }

    }
}

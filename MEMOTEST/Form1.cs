using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMOTEST
{
    public partial class Form1 : Form
    {
        TABLERO tablero  = new TABLERO();
        JUEGO juego = new JUEGO();

        public Form1()
        {
            InitializeComponent();
            tablero.EnviarCasillero += Tablero_EnviarCasillero;
            juego.EnviarError += Juego_EnviarError;
        }

        private void Juego_EnviarError()
        {
            MessageBox.Show("Error");
            foreach(Control control in this.Controls)
            {
                if(control is UI_CASILLERO)
                {
                    ((UI_CASILLERO)control).SetearImagen();
                }
            }
        }

        private void Tablero_EnviarCasillero(CASILLERO casillero)
        {
            UI_CASILLERO cas = new UI_CASILLERO();
            int x = casillero.X * casillero.Ancho + 10 * casillero.X;
            int y = casillero.Y * casillero.Ancho + 10 * casillero.Y;
            cas.Location = new Point(x, y);
            cas.Size = new Size(casillero.Ancho, casillero.Ancho);
            cas.Casillero = casillero;
            cas.EnviarCasillero += Cas_EnviarCasillero;

            this.Controls.Add(cas);


        }

        private void Cas_EnviarCasillero(CASILLERO casillero)
        {
            juego.CompararCasillero(casillero);
            if(juego.Ganador(tablero))
            {
                MessageBox.Show("Ganaste");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tablero.CrearTablero();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMOTEST
{
    public partial class UI_CASILLERO : UserControl
    {
        public event delEnviarCasillero EnviarCasillero;

        public UI_CASILLERO()
        {
            InitializeComponent();
        }

        private void UI_CASILLERO_Load(object sender, EventArgs e)
        {

        }

        private CASILLERO _casillero;

        public CASILLERO Casillero
        {
            get { return _casillero; }
            set { _casillero = value;
                SetearImagen();
            }
        }

        public void SetearImagen()
        {
            if(_casillero.Ficha.Estado == ESTADO.Cubierto)
            {
                pictureBox1.Image = Image.FromFile(@"IMG\Fondo.jpg");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(_casillero.Ficha.Imagen);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(_casillero.Ficha.Estado == ESTADO.Cubierto)
            {
                _casillero.Ficha.Estado = ESTADO.Descubierto;
                SetearImagen();
                this.EnviarCasillero(_casillero);
            }
        }
    }
}

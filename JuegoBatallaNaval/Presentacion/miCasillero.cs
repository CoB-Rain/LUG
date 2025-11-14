using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class miCasillero : UserControl
    {
        public miCasillero()
        {
            InitializeComponent();
        }

        private void miCasillero_Load(object sender, EventArgs e)
        {
            
        }

        private BE.CASILLERO _casillero = new BE.CASILLERO();

        public BE.CASILLERO Casillero
        {
            get { return _casillero; }
            set { _casillero = value;
                SetearImagen();
            }
        }

        private void SetearImagen()
        {
            if(_casillero.Estado == BE.ESTADO_CASILLERO.Agua)
            {
                pictureBox1.Image = Image.FromFile(@"IMG\AGUA.jpg");
            }
            else if(_casillero.Estado == BE.ESTADO_CASILLERO.Tocado)
            {
                pictureBox1.Image = Image.FromFile(@"IMG\TOCADO.jpg");
            }
        }

        private void VerificarEstado()
        {
            if (_casillero.Estado == BE.ESTADO_CASILLERO.Ocupado)
            {
                _casillero.Estado = BE.ESTADO_CASILLERO.Tocado;
                SetearImagen();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) => VerificarEstado();
    }
}

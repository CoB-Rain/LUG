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
                _casillero.Imagen = @"IMG\AGUA.jpg";
            }
            else if(_casillero.Estado == BE.ESTADO_CASILLERO.Tocado)
            {
                _casillero.Imagen = @"IMG\TOCADO.jpg";
            }
            pictureBox1.Image = Image.FromFile(_casillero.Imagen);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if(_casillero.Estado == BE.ESTADO_CASILLERO.Agua)
            {
                _casillero.Estado = BE.ESTADO_CASILLERO.Tocado;
            }
            else
            {
                _casillero.Estado = BE.ESTADO_CASILLERO.Agua;
            }
            SetearImagen();
        }
    }
}

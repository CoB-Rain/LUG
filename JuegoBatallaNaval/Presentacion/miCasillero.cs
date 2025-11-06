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
            pictureBox1.Image = Image.FromFile(@"IMG\AGUA.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

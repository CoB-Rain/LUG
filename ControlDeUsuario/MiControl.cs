using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeUsuario
{
    public partial class MiControl : UserControl
    {
        public MiControl()
        {
            InitializeComponent();
        }

        private void MiControl_Load(object sender, EventArgs e)
        {

        }

        private bool _requerido;

        public bool Requerido
        {
            get { return _requerido; }
            set { _requerido = value; }
        }

        public string Etiqueta
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Texto
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public bool Validar()
        {
            bool ok = (!_requerido) || (_requerido && !string.IsNullOrWhiteSpace(textBox1.Text));

            if(!ok)
            {
                textBox1.BackColor = Color.Coral;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }

                return ok;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
    }
}

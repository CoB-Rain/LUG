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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = true;
            foreach (Control control in this.Controls)
            {
                if(control is MiControl)
                {
                    ok = ok & ((MiControl)control).Validar();
                }
            }
            if(!ok)
            {
                MessageBox.Show("Error");
            }

            miControl1.Validar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SEXO.Sexos;
            comboBox1.DisplayMember = "Sexo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USUARIO usuario = new USUARIO();
            usuario.Nombre = textBox1.Text;
            usuario.Contraseña = textBox2.Text;
            usuario.Sexo = comboBox1.SelectedItem as SEXO;
            usuario.Grabar();
            this.Close();
        }
    }
}

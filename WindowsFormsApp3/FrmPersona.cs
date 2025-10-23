using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FrmPersona : Form
    {
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            ACCESO acceso = new ACCESO();
            acceso.Abrir();
            listBox1.DataSource = TITULO.Listar(acceso);
            acceso.Cerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PERSONA p = new PERSONA();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;

            foreach(var item in listBox1.SelectedItems)
            {
                p.Titulos.Add(item as TITULO);
            }

            p.Insertar();
        }
    }
}

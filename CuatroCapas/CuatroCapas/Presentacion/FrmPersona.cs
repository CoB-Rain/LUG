using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FrmPersona : Form
    {
        BLL.Titulo gestorTitulo = new BLL.Titulo();
        BLL.Persona gestorPersona = new BLL.Persona();

        public FrmPersona()
        {
            InitializeComponent();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {

            listBox1.DataSource = gestorTitulo.Listar();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            BE.PERSONA p = new BE.PERSONA();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;

            foreach (var item in listBox1.SelectedItems)
            {
                p.Titulos.Add((item as BE.Titulo));
            }

            gestorPersona.Grabar(p);
        }
    }
}

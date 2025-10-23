using Negocio;
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

namespace Transacciones
{
    public partial class frmPersona : Form
    {
        public frmPersona()
        {
            InitializeComponent();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
         
            listBox1.DataSource = Titulo.Listar();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PERSONA p = new PERSONA();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;

            foreach (var item in listBox1.SelectedItems)
            {                
                p.Titulos.Add( (item as Titulo));
            }

            p.Insertar();
        }
    }
}

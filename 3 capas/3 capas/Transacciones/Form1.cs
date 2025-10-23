using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
namespace Transacciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            Enlazar();
        }

        void Enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Titulo.Listar();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
     
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Titulo t = new Titulo(); 
            t.Descripcion = textBox1.Text;
            t.Insertar();
            Enlazar();
        }
    }
}

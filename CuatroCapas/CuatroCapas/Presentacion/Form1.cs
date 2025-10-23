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
    public partial class Form1 : Form
    {
        BLL.Titulo gestorTitulo = new BLL.Titulo();
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
            dataGridView1.DataSource = gestorTitulo.Listar();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            BE.Titulo t = new BE.Titulo();
            t.Descripcion = textBox1.Text;
            gestorTitulo.Grabar(t);
            Enlazar();
        }
    }
}


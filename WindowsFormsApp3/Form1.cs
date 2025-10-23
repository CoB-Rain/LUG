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
    public partial class Form1 : Form
    {
        ACCESO acceso = new ACCESO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acceso.Abrir();
            Enlazar();
        }

        public void Enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TITULO.Listar(acceso);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            acceso.Cerrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acceso.IniciarTx();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acceso.ConfirmarTx();
            Enlazar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            acceso.DeshacerTx();
            Enlazar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TITULO t = new TITULO();
            t.Acceso = acceso;
            t.Descripcion = textBox1.Text;
            t.Insertar();
            Enlazar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        PRODUCTO tmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FRMLOGIN frm = new FRMLOGIN();
            frm.ShowDialog();
            Enlazar();
        }

        void Enlazar()
        {
            comboBox1.DataSource = PRODUCTO.Listar();
            comboBox1.DisplayMember = "Descripcion";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( comboBox1.SelectedItem != null)
            {
                tmp = comboBox1.SelectedItem as PRODUCTO;
                textBox1.Text = tmp.Descripcion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PRODUCTO p = new PRODUCTO();
            p.Descripcion = textBox1.Text;
            p.Insertar();
            Enlazar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                tmp.Descripcion = textBox1.Text;
                tmp.Editar();
                Enlazar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
             
                tmp.Borrar();
                Enlazar();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPAS
{
    public partial class Form1 : Form
    {
        BE.PRODUCTO producto;

        BLL.PRODUCTO gestor = new BLL.PRODUCTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enlazar();
        }

        private void Enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.Listar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto = dataGridView1.Rows[e.RowIndex].DataBoundItem as BE.PRODUCTO;

            textBox1.Text = producto.Nombre;
            textBox2.Text = producto.Precio.ToString();
        }

        private void Grabar()
        {
            producto.Nombre = textBox1.Text;
            producto.Precio = float.Parse(textBox2.Text);
            gestor.Grabar(producto);
            producto = null;
            Enlazar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto = new BE.PRODUCTO();
            Grabar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (producto != null)
            {
                Grabar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (producto != null)
            {
                gestor.Borrar(producto);
                Enlazar();
            }
        }
    }
}

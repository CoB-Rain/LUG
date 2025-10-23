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
        FACTURA factura;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.DataSource = PRODUCTO.Listar();
            comboBox1.DisplayMember = "Descripcion";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            factura = new FACTURA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            ITEM item = new ITEM();
            item.Cantidad = int.Parse(textBox1.Text);
            item.Producto = comboBox1.SelectedItem as PRODUCTO;
            factura.Detalle.Add(item);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled=true;
            button2.Enabled=false;
            button3.Enabled=false;
            factura.Insertar();
            factura = null;
        }
    }
}

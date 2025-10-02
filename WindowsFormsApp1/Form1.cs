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
        private PERSONA temp = null;

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
            dataGridView1.DataSource = PERSONA.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PERSONA p = new PERSONA();
            p.ID = int.Parse(textBox1.Text);
            p.Nombre = textBox2.Text;
            p.Apellido = textBox3.Text;
            p.Edad = int.Parse(textBox4.Text);
            p.Insertar();
            Enlazar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(temp != null)
            {
                temp.ID = int.Parse(textBox1.Text);
                temp.Nombre = textBox2.Text;
                temp.Apellido = textBox3.Text;
                temp.Edad = int.Parse(textBox4.Text);
                temp.Editar();
                Enlazar();
                temp = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(temp != null)
            {
                temp.Borrar();
                Enlazar();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                temp = dataGridView1.Rows[e.RowIndex].DataBoundItem as PERSONA;
                textBox1.Text = temp.ID.ToString();
                textBox2.Text = temp.Nombre;
                textBox3.Text = temp.Apellido;
                textBox4.Text = temp.Edad.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}

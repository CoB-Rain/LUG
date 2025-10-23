using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_1
{
    public partial class Form1 : Form
    {
        PERSONA tmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PERSONA p = new PERSONA();
            p.Nombre = textBox1.Text;
            p.Edad = int.Parse(textBox2.Text);
            p.Insertar();
            Enlazar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = TELEFONO.Leer();
            comboBox1.DisplayMember = "Numero";
            Enlazar();
        }


        void Enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PERSONA.Listar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tmp = dataGridView1.Rows[e.RowIndex].DataBoundItem as PERSONA;
            textBox1.Text = tmp.Nombre;
            textBox2.Text = tmp.Edad.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            { 
                tmp.Borrar();
                tmp =null;
                Enlazar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {            

            if (tmp != null)
            {
                tmp.Edad = int.Parse(textBox2.Text);
                tmp.Nombre = textBox1.Text;
                tmp.Editar();
                tmp = null;
                Enlazar();
            }
        }
    }
}

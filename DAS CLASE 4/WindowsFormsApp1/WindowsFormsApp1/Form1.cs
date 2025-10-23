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
        EQUIPO equipo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = BARRIO.Listar();
        }


        private void Enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = EQUIPO.ListarEquipos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            equipo = new EQUIPO();
            equipo.Equipo = textBox1.Text;
            equipo.Barrio = comboBox1.SelectedItem as BARRIO;

            equipo.Insertar();
            equipo = null;
            Enlazar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            equipo.Equipo = textBox1.Text;
            equipo.Barrio = comboBox1.SelectedItem as BARRIO;

            equipo.Editar();
            equipo = null;
            Enlazar();
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            equipo.Borrar();
            equipo = null;
            Enlazar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            equipo = dataGridView1.Rows[e.RowIndex].DataBoundItem as EQUIPO;
            textBox1.Text = equipo.Equipo;

            comboBox1.SelectedItem = (from object item in comboBox1.Items
                                      where ((BARRIO)item).Id == equipo.Barrio.Id
                                      select item
                                      ).First();

        }
    }
}

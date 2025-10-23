using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        BE.USUARIO usuarioTemp;
        BLL.USUARIO gestor = new BLL.USUARIO();

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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(usuarioTemp != null)
            {
                gestor.Borrar(usuarioTemp);
                Enlazar();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuarioTemp = (BE.USUARIO)dataGridView1.CurrentRow.DataBoundItem;
        }
    }
}

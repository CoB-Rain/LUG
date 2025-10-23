using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FRMLOGIN : Form
    {
        bool ok = false;

        public FRMLOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();

            ACCESO aCCESO = new ACCESO();
            aCCESO.Abrir();

            parameters.Add(aCCESO.CrearParametro("@usu", textBox1.Text));
            parameters.Add(aCCESO.CrearParametro("@pass", textBox2.Text));
            string sql = $"USUARIO_LISTAR";
            ok = aCCESO.LeerEscalar(sql,parameters) == 1 ;
            aCCESO.Cerrar();
            this.Close();   
        }

        private void FRMLOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ok)
            { 
                e.Cancel = true;
            }
        }
    }
}

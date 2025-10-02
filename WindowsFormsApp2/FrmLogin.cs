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

namespace WindowsFormsApp2
{
    public partial class FrmLogin : Form
    {
        private bool _ok = false;

        public bool OK
        {
            get { return _ok; }
            set { _ok = value; }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ACCESO acceso = new ACCESO();
            string sql = $"SELECT * FROM USUARIO WHERE NOMBRE = '{textBox1.Text}' and CONTRASEÑA = '{textBox2.Text}'";
            acceso.Abrir();
            SqlDataReader reader = acceso.Leer(sql);
            _ok = reader.HasRows;
            reader.Close();

            acceso.Cerrar();
            this.Close();
        }
    }
}

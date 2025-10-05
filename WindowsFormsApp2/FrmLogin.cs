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

        private USUARIO _usuario;

        public USUARIO Usuario
        {
            get { return _usuario; }
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
            //string sql = $"SELECT * FROM USUARIO WHERE NOMBRE = '{textBox1.Text}' and CONTRASEÑA = '{textBox2.Text}'";
            string sql = $"SELECT * FROM USUARIO WHERE NOMBRE = @nom and CONTRASEÑA = @pass";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.CrearParametro("@nom", textBox1.Text));
            parameters.Add(acceso.CrearParametro("@pass", textBox2.Text));

            acceso.Abrir();
            SqlDataReader reader = acceso.Leer(sql, parameters);
            _ok = reader.HasRows;

            if(_ok)
            {
                reader.Read();
                _usuario = new USUARIO();
                _usuario.ID = int.Parse(reader["ID"].ToString());
                _usuario.Nombre = reader["NOMBRE"].ToString();
                _usuario.Contraseña = reader["CONTRASEÑA"].ToString();
                _usuario.Sexo = (from SEXO s in SEXO.Sexos
                                 where s.ID == int.Parse(reader["ID_SEXO"].ToString())
                                 select s).First();

            }

            reader.Close();

            acceso.Cerrar();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegistro frm = new FrmRegistro();
            frm.ShowDialog();
        }
    }
}

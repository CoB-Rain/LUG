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
    public partial class FrmAltaUsuario : Form
    {
        BE.USUARIO usuario;
        BLL.USUARIO gestor = new BLL.USUARIO();

        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            usuario = new BE.USUARIO();
            Registrar();
        }

        private void Registrar()
        {
            if(!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                usuario.Nombre = txtNombre.Text;
                usuario.Contraseña = txtContraseña.Text;
                gestor.Grabar(usuario);
                if(gestor.resultado == -1)
                {
                    MessageBox.Show("Este usuario ya existe!");
                }
                usuario = null;
                this.Close();
            }
            else
            {
                MessageBox.Show("Asegurate de que ningun campo este vacio!");
            }
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

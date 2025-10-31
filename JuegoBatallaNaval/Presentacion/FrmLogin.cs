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
    public partial class FrmLogin : Form
    {
        EstadoVisibilidad estado = new EstadoVisibilidad();

        BE.USUARIO usuario = new BE.USUARIO();
        BLL.USUARIO gestor = new BLL.USUARIO();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            estado = EstadoVisibilidad.Oculto;
            pictureBox1.Image = Image.FromFile(@"IMG\OJO_CERRADO.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(estado == EstadoVisibilidad.Oculto)
            {
                estado = EstadoVisibilidad.Visible;
                pictureBox1.Image = Image.FromFile(@"IMG\OJO_ABIERTO.jpg");
                txtContraseña.PasswordChar = '\0';
            }
            else if(estado == EstadoVisibilidad.Visible)
            {
                estado = EstadoVisibilidad.Oculto;
                pictureBox1.Image = Image.FromFile(@"IMG\OJO_CERRADO.jpg");
                txtContraseña.PasswordChar = '*';
            }
        }

        private void lnkCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAltaUsuario frm = new FrmAltaUsuario();
            frm.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                BE.USUARIO usuarioBuscar = new BE.USUARIO();
                usuarioBuscar.Nombre = txtNombre.Text;
                usuarioBuscar.Contraseña = txtContraseña.Text;
                usuario = gestor.Buscar(usuarioBuscar);
                if (usuario.Nombre == usuarioBuscar.Nombre && usuario.Contraseña == usuarioBuscar.Contraseña)
                {
                    MessageBox.Show($"Bienvenido {usuario.Nombre}!");
                    this.Hide();
                    using (Form1 frm = new Form1(usuario, gestor))
                    {
                        frm.ShowDialog();
                    }
                    this.Show();
                    txtNombre.Text = "";
                    txtContraseña.Text = "";
                }
                else
                {
                    MessageBox.Show("No existe este usuario");
                }
            }
            else
            {
                MessageBox.Show("Asegurate de que ningun campo este vacio!");
            }
        }
    }
}

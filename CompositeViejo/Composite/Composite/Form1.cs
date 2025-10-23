using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite
{
    public partial class Form1 : Form
    {
        GESTOR gestor = new GESTOR();

        private USUARIO usuario;

        public USUARIO Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        void Validar(PERMISO p, Form frm)
        {            
            if (usuario.TienePermiso(p))
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Close();
                MessageBox.Show("No tiene el permiso necesario para acceder");
            }
        
        }


     

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bACKUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validar(new PERMISO(7), new frmBackup());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usuario = new USUARIO();
            usuario.Id =1;
            usuario.Nombre = "Christian";
            gestor.DevolverPermisos();

            gestor.SetearPermisos(usuario);
       
        }

        private void cONSULTAPERFILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validar(new PERMISO(1), new frmConsultaPErfil());
        }

        private void cONSULTACLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validar(new PERMISO(2), new frmConsultaCliente());
        }

        private void cONSULTAPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validar(new PERMISO(3), new frmConsultaProducto());
        }

        private void aBMCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validar(new PERMISO(4), new frmABMCliente());
        }

        private void aBMPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validar(new PERMISO(5), new frmABMProducto());
        }

        private void aBMUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validar(new PERMISO(6), new frmABMUsuario());
        }
    }
}

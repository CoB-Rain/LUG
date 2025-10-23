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

        USUARIO usuario = new USUARIO();
        List<PERMISO> permisos = new List<PERMISO>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrearPermisos();
        }

        void CrearPermisos()
        { 
            Acceso ac = new Acceso();
            ac.Abrir();
            DataTable tabla = ac.Leer("listar_permisos");
           

            foreach (DataRow reg in tabla.Rows) 
            {
                PERMISO p = null;
                if (reg["GRUPO"].ToString() == "SI")
                {
                    p = new GRUPO();
                }
                else
                { 
                    p = new PERMISO();
                }
                p.Nombre = reg["NOMBRE"].ToString();
                p.Id = int.Parse(reg["id"].ToString());
                permisos.Add(p);
            }
            tabla = ac.Leer("grupos_listar");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            { 
                GRUPO g = (from PERMISO grupo in permisos
                           where grupo.Id == int.Parse(registro["IDGRUPO"].ToString())
                           select grupo) .First() as GRUPO;
            
                PERMISO p = (from PERMISO Per in permisos
                             where Per.Id == int.Parse(registro["IDPERMISO"].ToString())
                           select Per).First() ;

                g.Permisos.Add(p);
            }



            //permisos.Add(new PERMISO("Login",1));
            //permisos.Add(new PERMISO("ALTA cliente",2));
            //permisos.Add(new PERMISO("BAJA cliente",3));
            //permisos.Add(new PERMISO("EDITAR cliente", 4));
            //permisos.Add(new PERMISO("BACKUP",5));
            //permisos.Add(new PERMISO("RESTORE",6));
            //permisos.Add(new PERMISO("ASIGNAR PERMISOS",7));
            //permisos.Add(new PERMISO("CREAR USUARIOS",8));


            //GRUPO bdas = new GRUPO();
            // bdas.Nombre = "BASE DATOS";
            // bdas.Id = 101;

            // bdas.Permisos.Add(permisos[4]);
            // bdas.Permisos.Add(permisos[5]);

            // permisos.Add(bdas);

            // GRUPO administradores = new GRUPO();
            // administradores.Permisos.Add(bdas);
            // administradores.Permisos.Add(permisos[6]);
            // administradores.Permisos.Add(permisos[7]);
            // permisos.Add(administradores);

            usuario.Permisos.Add(permisos[0]);
            usuario.Permisos.Add(permisos[9]);
            
        
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Validar(permisos[0]))
            {
                frm_OK f = new frm_OK();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show($"No tiene el permiso {permisos[0].Nombre}");
            }
        }

        private void aLTACLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Validar(permisos[1]))
            {
                frm_OK f = new frm_OK();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show($"No tiene el permiso {permisos[1].Nombre}");
            }
        }

        private void eDITARCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Validar(permisos[2]))
            {
                frm_OK f = new frm_OK();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show($"No tiene el permiso {permisos[2].Nombre}");
            }
        }

        private void bAJACLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Validar(permisos[3]))
            {
                frm_OK f = new frm_OK();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show($"No tiene el permiso {permisos[3].Nombre}");
            }
        }

        private void bACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Validar(permisos[4]))
            {
                frm_OK f = new frm_OK();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show($"No tiene el permiso {permisos[4].Nombre}");
            }
        }

        private void rESTOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Validar(permisos[5]))
            {
                frm_OK f = new frm_OK();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show($"No tiene el permiso {permisos[5].Nombre}");
            }
        }

        private void cREARUSUARISOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Validar(permisos[6]))
            {
                frm_OK f = new frm_OK();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show($"No tiene el permiso {permisos[6].Nombre}");
            }
        }

        private void aSIGNARPERSMISOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.Validar(permisos[7]))
            {
                frm_OK f = new frm_OK();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show($"No tiene el permiso {permisos[7].Nombre}");
            }
        }
    }
}

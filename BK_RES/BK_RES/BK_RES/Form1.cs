using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BK_RES
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ACCESO acceso = new ACCESO();
            acceso.Abrir();

            DataTable tabla = acceso.Leer("usuario_listar");


            int cantidad = tabla.Rows.Count;

            List<SqlParameter> parametros = new List<SqlParameter>();


            SqlParameter p ;
            SqlParameter f;
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                p = new SqlParameter();
                p.ParameterName = "@desc";
                p.DbType = DbType.String;
                parametros.Add(p);
                p.Value = $"Usuario_{cantidad}";
                acceso.Escribir("usuario_insertar", parametros);

                parametros.Clear();
                
                p = new SqlParameter();
                p.ParameterName = "@desc";
                p.DbType = DbType.String;
                p.Value = $"Se creo el usuario Usuario_{cantidad}";

                f= new SqlParameter();
                f.Value = DateTime.Now.Ticks;
                f.ParameterName = "@fecha";
                parametros.Add(p);
                parametros.Add(f);

                acceso.Escribir("bitacora_insertar", parametros);
                parametros.Clear();
                cantidad++;
            }
            acceso.Cerrar();
            acceso = null;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            ACCESO acceso = new ACCESO();
            acceso.Abrir();

            acceso.Backup();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p;
            SqlParameter f;
            p = new SqlParameter();
            p.ParameterName = "@desc";
            p.DbType = DbType.String;
            p.Value = $"Se realizo un backup";

            f = new SqlParameter();
            f.Value = DateTime.Now.Ticks;
            f.ParameterName = "@fecha";
            parametros.Add(p);
            parametros.Add(f);

            acceso.Escribir("bitacora_insertar", parametros);

            acceso.Cerrar();
            acceso = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ofs.FileName = "";
            
            if (ofs.ShowDialog() == DialogResult.OK)
            {
                string filename = ofs.FileName;
                ACCESO acceso = new ACCESO();
                acceso.Abrir();

                DataSet ds = new DataSet();
                DataTable tabla = acceso.Leer("BITACORA_LEER");
                ds.Tables.Add(tabla);
                ds.WriteXml("D:\\BKS\\bitacora.xml");
                acceso.Restore(filename);
                acceso.Cerrar();
                acceso.Abrir();
                acceso.Escribir("BITACORA_BORRAR");
                List<SqlParameter> parametros = new List<SqlParameter>();
                foreach (DataRow row in tabla.Rows)
                {

                    SqlParameter p;
                    SqlParameter f;
                    p = new SqlParameter();
                    parametros.Clear();

                    p = new SqlParameter();
                    p.ParameterName = "@desc";
                    p.DbType = DbType.String;
                    p.Value = row[1].ToString();

                    f = new SqlParameter();
                    f.Value = long.Parse(row[0].ToString());
                    f.DbType = DbType.Int64;
                    f.ParameterName = "@fecha";
                    parametros.Add(p);
                    parametros.Add(f);

                    acceso.Escribir("bitacora_insertar", parametros);
                }
                acceso.Cerrar();
                acceso = null;

            }
        }
    }
}

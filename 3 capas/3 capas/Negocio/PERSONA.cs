using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso;


namespace Negocio
{
    public class PERSONA
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private List<Titulo> titulos = new List<Titulo>();

        public List<Titulo> Titulos
        {
            get { return titulos; }

        }

        public int Insertar()
        {
            ACCESO acceso = new ACCESO();
            acceso.Abrir();
            acceso.IniciarTx();
            int res = 0;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nom", nombre));
            parametros.Add(acceso.CrearParametro("@ape", apellido));
            res = acceso.Escribir("PERSONA_INSERTAR", parametros);
            if (res == 1)
            {
                this.id = acceso.LeerEscalar("PERSONA_OBTENERMAXID");
                foreach (Titulo titulo in titulos)
                {
                    parametros = null;
                    parametros = new List<SqlParameter>();
                    parametros.Add(acceso.CrearParametro("@id", this.id));
                    parametros.Add(acceso.CrearParametro("@id_t", titulo.Id));
                    acceso.Escribir("PERSONA_TITULO_INSERTAR", parametros);
                }
                acceso.Confirmar();
            }
            else
            {
                acceso.Rollback();
            }
            acceso.Cerrar();
            return res;
        }
    }
}

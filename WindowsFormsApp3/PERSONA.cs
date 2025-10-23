using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp3
{
    public class PERSONA
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private List<TITULO> _titulos = new List<TITULO>();

		public List<TITULO> Titulos
		{
			get { return _titulos; }
		}

		public int Insertar()
		{
			ACCESO acceso = new ACCESO();
			acceso.Abrir();
			acceso.IniciarTx();
			int res = 0;
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(acceso.CrearParametro("@nom", _nombre));
            parametros.Add(acceso.CrearParametro("@ape", _apellido));
			res = acceso.Escribir("PERSONA_INSERTAR", parametros);
			if(res == 1)
			{
				this._id = acceso.LeerEscalar("PERSONA_OBTENERMAXID");
				foreach (TITULO titulo in _titulos)
				{
					parametros = null;
					parametros = new List<SqlParameter>();
                    parametros.Add(acceso.CrearParametro("@id", this._id));
                    parametros.Add(acceso.CrearParametro("@id_t", titulo.ID));
					acceso.Escribir("PERSONA_TITULO_INSERTAR", parametros);
                }
				acceso.ConfirmarTx();
			}
			else
			{
				acceso.DeshacerTx();
			}
			acceso.Cerrar();
			return res;
		}
	}
}
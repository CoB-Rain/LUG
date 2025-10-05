using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    public class USUARIO
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

		private string _contraseña;

		public string Contraseña
		{
			get { return _contraseña; }
			set { _contraseña = value; }
		}

		private SEXO _sexo;

		public SEXO Sexo
		{
			get { return _sexo; }
			set { _sexo = value; }
		}

		private ACCESO acceso;

		public void Grabar()
		{
			string sql = string.Empty;
			acceso = new ACCESO();
			acceso.Abrir();
			if(this._id == 0)
			{
				sql = "SELECT ISNULL(MAX(ID), 0) +1 FROM USUARIO";
				_id = acceso.LeerEscalar(sql);


				sql = "insert into usuario values (@id, @nom, @pass, @id_s)";
			}
			else
			{
                sql = "update usuario set nombre = @nom, contraseña = @pass, id_sexo = @id_s where id = @id";

            }
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(acceso.CrearParametro("@id", _id));
            parametros.Add(acceso.CrearParametro("@nom", _nombre));
            parametros.Add(acceso.CrearParametro("@pass", _contraseña));
            parametros.Add(acceso.CrearParametro("@id_s", _sexo.ID));

			acceso.Escribir(sql, parametros);
			acceso.Cerrar();
        }

    }
}
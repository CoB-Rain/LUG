using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    public class SEXO
    {
        private static List<SEXO> _sexos = new List<SEXO>();

        public static List<SEXO> Sexos
        {
            get { return _sexos; }
            set { _sexos = value; }
        }

        private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _sexo;

		public string Sexo
		{
			get { return _sexo; }
			set { _sexo = value; }
		}

        public static void Listar()
        {
            ACCESO acceso = new ACCESO();
            acceso.Abrir();
            SqlDataReader reader = acceso.Leer("SELECT * FROM SEXO");
            while (reader.Read())
            {
                SEXO sexo = new SEXO();
                sexo._id = int.Parse(reader["ID"].ToString());
                sexo._sexo = reader["SEXO"].ToString();
                _sexos.Add(sexo);
            }
            reader.Close();
            reader = null;
            acceso.Cerrar();
        }
    }
}
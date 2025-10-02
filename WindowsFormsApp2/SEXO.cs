using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    public class SEXO
    {
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
	}
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class FACTURA
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}


		private int numero;

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		List<ITEM> detalle = new List<ITEM>();
		
		public List<ITEM> Detalle 
		{ 
			get { 
				return detalle;	
			} 
		}

		public void Insertar()
		{ 
			ACCESO acceso = new ACCESO();
			acceso.Abrir();

			acceso.IniciarTx();

			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(acceso.CrearParametro("@NUMERO", this.numero));
            parametros.Add(acceso.CrearParametro("@ID", this.numero, System.Data.ParameterDirection.Output));

            int res = acceso.Escribir("FACTURA_INSERTAR", parametros);
			
			if (res == 1)
			{
				this.id =int.Parse( parametros[1].Value.ToString());

				bool ok = true;

				foreach (ITEM item in detalle)
				{
                    parametros = new List<SqlParameter>();
                    parametros.Add(acceso.CrearParametro("@ID_FACTURA", this.id));
                    parametros.Add(acceso.CrearParametro("@ID_PRODUCTO", item.Producto.Id));
                    parametros.Add(acceso.CrearParametro("@CANTIDAD", item.Cantidad));

					res= acceso.Escribir("DETALLE_INSERTAR",parametros);

					ok = (res== 1) && ok;

                }

				if (ok)
				{
					acceso.ConfirmarTx();
				}
				else
				{ 
					acceso.DeshacerTx();
				}
			}
			else
			{ 
				acceso.DeshacerTx();
			
			}
			acceso.Cerrar();
		}



	}
}
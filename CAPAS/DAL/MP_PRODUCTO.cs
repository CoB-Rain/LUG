using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_PRODUCTO : MAPPER<BE.PRODUCTO>
    {
        public override int Borrar(PRODUCTO objeto)
        {
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", objeto.ID));
            int res = acceso.Escribir("PRODUCTO_BORRAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override int Editar(PRODUCTO objeto)
        {
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", objeto.ID));
            parametros.Add(acceso.CrearParametro("@nombre", objeto.Nombre));
            parametros.Add(acceso.CrearParametro("@precio", objeto.Precio));
            int res = acceso.Escribir("PRODUCTO_EDITAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override int Insertar(PRODUCTO objeto)
        {
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombre", objeto.Nombre));
            parametros.Add(acceso.CrearParametro("@precio", objeto.Precio));
            int res = acceso.Escribir("PRODUCTO_INSERTAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override List<PRODUCTO> Listar()
        {
            List<PRODUCTO> productos = new List<PRODUCTO>();
            acceso = new ACCESO();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("PRODUCTO_LISTAR");
            acceso.Cerrar();
            foreach (DataRow row in tabla.Rows)
            {
                PRODUCTO p = new PRODUCTO();
                p.ID = int.Parse(row["ID_PRODUCTO"].ToString());
                p.Precio = float.Parse(row["PRECIO"].ToString());
                p.Nombre = row["NOMBRE"].ToString();
                productos.Add(p);
            }
            return productos;
        }
    }
}

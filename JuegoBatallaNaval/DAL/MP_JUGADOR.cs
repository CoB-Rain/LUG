using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MP_JUGADOR : MAPPER<BE.JUGADOR>
    {
        public override int Borrar(JUGADOR obj)
        {
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", obj.ID));
            int res = acceso.Escribir("JUGADOR_BORRAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override int Editar(JUGADOR obj)
        {
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", obj.ID));
            parametros.Add(acceso.CrearParametro("@PG", obj.TotalPartidasGanadas));
            parametros.Add(acceso.CrearParametro("@PE", obj.TotalPartidasEmpatadas));
            parametros.Add(acceso.CrearParametro("@PP", obj.TotalPartidasPerdidas));
            int res = acceso.Escribir("JUGADOR_EDITAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override int Insertar(JUGADOR obj)
        {
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", obj.ID));
            int res = acceso.Escribir("JUGADOR_INSERTAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override List<JUGADOR> Listar()
        {
            List<JUGADOR> jugadores = new List<JUGADOR>();
            acceso = new ACCESO();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("JUGADOR_LISTAR");
            acceso.Cerrar();
            foreach (DataRow row in tabla.Rows)
            {
                JUGADOR j = new JUGADOR();
                j.ID = int.Parse(row["ID_JUGADOR"].ToString());
                j.TotalPartidasGanadas = int.Parse(row["PARTIDAS_GANADAS"].ToString());
                j.TotalPartidasEmpatadas = int.Parse(row["PARTIDAS_EMPATADAS"].ToString());
                j.TotalPartidasPerdidas = int.Parse(row["PARTIDAS_PERDIDAS"].ToString());
                jugadores.Add(j);
            }
            return jugadores;
        }

    }
}
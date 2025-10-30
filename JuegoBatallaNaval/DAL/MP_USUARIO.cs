using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MP_USUARIO : MAPPER<BE.USUARIO>
    {
        public override int Borrar(USUARIO obj)
        {
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", obj.ID));
            int res = acceso.Escribir("USUARIO_BORRAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override int Editar(USUARIO obj)
        {
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", obj.ID));
            parametros.Add(acceso.CrearParametro("@nom", obj.Nombre));
            parametros.Add(acceso.CrearParametro("@pass", obj.Contraseña));
            int res = acceso.Escribir("USUARIO_EDITAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override int Insertar(USUARIO obj)
        {
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nom", obj.Nombre));
            parametros.Add(acceso.CrearParametro("@pass", obj.Contraseña));
            int res = acceso.Escribir("USUARIO_INSERTAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override List<USUARIO> Listar()
        {
            List<USUARIO> usuarios = new List<USUARIO>();
            acceso = new ACCESO();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("USUARIO_LISTAR");
            acceso.Cerrar();
            foreach(DataRow row in tabla.Rows)
            {
                USUARIO u = new USUARIO();
                u.ID = int.Parse(row["ID_USUARIO"].ToString());
                u.Nombre = row["NOMBRE"].ToString();
                u.Contraseña = row["CONTRASEÑA"].ToString();
                usuarios.Add(u);
            }
            return usuarios;
        }

        public USUARIO Buscar(USUARIO usuario)
        {
            USUARIO usuarioEncontrado = new USUARIO();
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nom", usuario.Nombre));
            parametros.Add(acceso.CrearParametro("@pass", usuario.Contraseña));
            DataTable tabla = new DataTable();
            tabla = acceso.Leer("USUARIO_BUSCAR", parametros);
            acceso.Cerrar();
            bool ok = tabla.Rows.Count == 1;
            if (ok)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    usuarioEncontrado.ID = int.Parse(row["ID_USUARIO"].ToString());
                    usuarioEncontrado.Nombre = row["NOMBRE"].ToString();
                    usuarioEncontrado.Contraseña = row["CONTRASEÑA"].ToString();
                }
            }
            return usuarioEncontrado;
        }

        public int InsertarJugador(BE.USUARIO usuario)
        {
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id_usu", usuario.ID));
            int res = acceso.Escribir("USUARIO_INSERTAR_JUGADOR", parametros);
            acceso.Cerrar();
            return res;
        }

        public void ObtenerJugadores(BE.USUARIO usuario)
        {
            List<BE.JUGADOR> jugadores = new List<BE.JUGADOR>();
            acceso = new ACCESO();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_usu",usuario.ID));
            DataTable tabla = acceso.Leer("USUARIO_JUGADOR_LISTAR", parametros);
            acceso.Cerrar();
            foreach(DataRow row in tabla.Rows)
            {
                BE.JUGADOR j = new BE.JUGADOR();
                j.ID = int.Parse(row["ID_JUGADOR"].ToString());
                j.TotalPartidasGanadas = int.Parse(row["PARTIDAS_GANADAS"].ToString());
                j.TotalPartidasEmpatadas = int.Parse(row["PARTIDAS_EMPATADAS"].ToString());
                j.TotalPartidasPerdidas = int.Parse(row["PARTIDAS_PERDIDAS"].ToString());
                jugadores.Add(j);
            }
            usuario.Jugadores = null;
            usuario.Jugadores = jugadores;
        }
    }
}
using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MP_PERSONA : Mapper<BE.PERSONA>
    {
        public override void Borrar(PERSONA obj)
        {
            throw new NotImplementedException();
        }

        public override void Editar(PERSONA obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(PERSONA obj)
        {
            acceso.Abrir();
            acceso.IniciarTx();
            int res = 0;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nom", obj.Nombre));
            parametros.Add(acceso.CrearParametro("@ape", obj.Apellido));
            res = acceso.Escribir("PERSONA_INSERTAR", parametros);
            if (res == 1)
            {
                obj.Id = acceso.LeerEscalar("PERSONA_OBTENERMAXID");
                foreach (Titulo titulo in obj.Titulos)
                {
                    parametros = null;
                    parametros = new List<SqlParameter>();
                    parametros.Add(acceso.CrearParametro("@id", obj.Id));
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
        }

        public override List<PERSONA> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
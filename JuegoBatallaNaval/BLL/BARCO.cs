using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BARCO
    {
        public BE.BARCO CrearBarco(TipoBarco tipo)
        {
            BE.BARCO barco = new BE.BARCO();
            barco.Tipo = tipo;
            switch (tipo)
            {
                case TipoBarco.BatallaNaval:
                    barco.Imagen = @"IMG\BATALLA NAVAL";
                    break;
                case TipoBarco.PortaAviones:
                    barco.Imagen = @"IMG\PORTA AVIONES";
                    break;
                case TipoBarco.Fragata:
                    barco.Imagen = @"IMG\FRAGATA";
                    break;
                case TipoBarco.Buque:
                    barco.Imagen = @"IMG\BUQUE";
                    break;
                case TipoBarco.Acorazado:
                    barco.Imagen = @"IMG\ACORAZADO";
                    break;
                default:
                    break;
            }
            return barco;
        }
    }
}
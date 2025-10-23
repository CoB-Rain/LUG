using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class TABLERO
    {
        //cantidad maxima de fichas por fila/columna
        //dimension espacio que va a ocupar en el formulario
        public BE.TABLERO CrearTablero(int cantidad, int dimension)
        {
            FICHA.Tamaño.X =  dimension;
            FICHA.Tamaño.Y = dimension;

            List<int> imagenes = new List<int>();
            int indice = 0;
            for(int i = 0; i< cantidad * cantidad; i++)
            {
                if (indice == 4)
                {
                    indice = 0;
                }
                imagenes.Add(indice);
                
                indice ++;
            }


            BE.TABLERO tablero = new BE.TABLERO();

            for (int fila = 0; fila < cantidad; fila++)
            {
                for (int columna = 0; columna < cantidad; columna++)
                {
                    BE.FICHA ficha = new BE.FICHA();
                    ficha.Posicion.Y = fila * (FICHA.Tamaño.Y + 10 ) ;
                    ficha.Posicion.X = columna * (FICHA.Tamaño.X + 10 ) ;

                    indice = Helper.rnd.Next(0, imagenes.Count);

                    switch (imagenes[indice])
                    { 
                        case 0:
                            {
                                ficha.Imagen = "caniche.jpg";
                                break;
                            }
                        case 1:
                            {
                                ficha.Imagen = "Escudo.png";
                                break ;
                            }
                        case 2:
                            {
                                ficha.Imagen = "Suegra.jpg";
                                break;
                            }
                        default:
                            {
                                ficha.Imagen = "copa.jpeg";
                                break;
                            }
                    }
                    imagenes.RemoveAt(indice);
                    tablero.Fichas.Add(ficha);  
                
                }            
            }
            return tablero;
        }


    }
}

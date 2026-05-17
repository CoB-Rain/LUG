using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Expresiones_Regulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Las expresiones regulares son patrones que se utilizan para buscar y manipular cadenas de texto.
            //Regex es la clase que se utiliza para trabajar con expresiones regulares en C#.
            //Regex utiliza la libreria "using System.Text.RegularExpressions;"
            //Las expresiones regulares son universales, las puedes usar en cualquier lenguaje de programacion.
            //esta expresion regular busca un digito numerico
            Regex regex = new Regex( @"\d");
            if(regex.IsMatch("65"))
                Console.WriteLine("Si");
            else
                Console.WriteLine("No");

            //Vamos a intentar ahora con un correo electronico
            //Esta expresion regular busca una cadena que contenga letras minusculas
            regex = new Regex(@"^[a-z]+$");
            if (regex.IsMatch("hjhjasd"))
                Console.WriteLine("Si");
            else
                Console.WriteLine("No");

            //Esta expresion regular busca una cadena que contenga letras minusculas y mayusculas
            regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch("hAjhjasdZ"))
                Console.WriteLine("Si");
            else
                Console.WriteLine("No");

            //Esta expresion regular busca una cadena que contenga letras minusculas, mayusculas y un arroba
            regex = new Regex(@"^[a-zA-Z]+@$");
            if (regex.IsMatch("hAjhjasdZ@"))
                Console.WriteLine("Si");
            else
                Console.WriteLine("No");

            //Esta expresion regular busca una cadena que contenga letras minusculas, mayusculas, un arroba y mas letras
            regex = new Regex(@"^[a-zA-Z]+@[a-zA-Z]+$");
            if (regex.IsMatch("hAjhjasdZ@hdeleon"))
                Console.WriteLine("Si");
            else
                Console.WriteLine("No");

            //Esta expresion regular busca una cadena que contenga letras minusculas, mayusculas, un arroba, mas letras y un punto
            regex = new Regex(@"^[a-zA-Z]+@[a-zA-Z]+\.$");
            if (regex.IsMatch("hAjhjasdZ@hdeleon."))
                Console.WriteLine("Si");
            else
                Console.WriteLine("No");

            //Esta expresion regular busca una cadena que contenga letras minusculas, mayusculas, un arroba, mas letras, un punto y dos o tres letras
            regex = new Regex(@"^[a-zA-Z]+@[a-zA-Z]+\.[a-zA-Z]{2,3}$");
            if (regex.IsMatch("hAjhjasdZ@hdeleon.net"))
                Console.WriteLine("Si");
            else
                Console.WriteLine("No");
            //Esta es una expresion regular basica para validar correos electronicos, pero existen muchas mas complejas que validan mas casos.
            //Con las expresiones regulares podemos hacer validaciones que parecen complejas pero no lo son.
            //Las expresiones regulares tambien sirven para filtrar datos entre una cadena de texto para colarlos.
            //sirven para validar, filtrar y manipular cadenas de texto.
            //Las expresiones regulares sirven para un monton de cosas.
        }
    }
}

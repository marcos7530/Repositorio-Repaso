using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            string _nombre = "marcoso";
            string _nombre2 = "marcos";
            string _apellido = "campos";
            string _nombreCompleto = _nombre + _apellido;
            string _saludo = $"hola {_nombreCompleto}";

            //Console.WriteLine(_saludo);

            Console.WriteLine(string.Format("La temperatura actual es {0}°C.", 20.4).ToUpper());

            Console.WriteLine(_saludo.ToUpper());

            if (_nombre.Equals(_nombre2))
            {
                Console.WriteLine("son iguales".ToUpper());
            }
            else
            {
                Console.WriteLine("noooo! son iguales".ToUpper());
            }


            var _indice = _nombre.IndexOf('o');

           /* Console.WriteLine(_indice);*/

            int[] arrayEnteros = new int[5];

            arrayEnteros[0] = 4;
            arrayEnteros[1] = 6;
            arrayEnteros[2] = 8;
            arrayEnteros[3] = 12;
            arrayEnteros[4] = 17;
            

            /*mostrar el array*/

            for (int i = 0; i < arrayEnteros.Length; i++)
            {
                Console.WriteLine(arrayEnteros[i]);
            }


            /*CREAR LISTA*/

            List<string> provincias = new List<string>();

            provincias.Add("tucuman");
            provincias.Add("salta");
            provincias.Add("santiago");

            provincias.AddRange(argentina);
            Console.ReadKey();

        }
    }
}

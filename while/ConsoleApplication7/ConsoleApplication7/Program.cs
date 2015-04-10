using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una planta que fabrica perfiles de hierro posee un lote de n piezas.
             * Confeccionar un programa que pida ingresar por teclado la cantidad 
             * de piezas a procesar y luego ingrese la longitud de cada perfil; sabiendo 
             * que la pieza cuya longitud esté comprendida en el rango de 1,20 y 1,30 
             * son aptas. Imprimir por pantalla la cantidad de piezas aptas que hay en el lote.*/
            int cont, cant, n;
            float pieza;
            cont = 1;
            cant = 0;
            Console.WriteLine("Digite la cantidad de piezas a procesar ");
            n = int.Parse(Console.ReadLine());
            while (cont <= n)
            {
                Console.WriteLine("Digite la longitud");
                pieza=float.Parse(Console.ReadLine());
                if ((pieza >= 1.20) && (pieza <= 1.30)){cant++;}
                cont++;
            }

            Console.WriteLine("la cantidad de piezas aptas es : " + cant);
            Console.ReadKey();
        }
    }
}

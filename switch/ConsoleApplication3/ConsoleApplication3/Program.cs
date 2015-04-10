using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número entre uno y cinco en castellano. Luego mostrar en formato numérico. 
             * Si se ingresa un valor fuera de dicho rango mostrar un mensaje indicando tal situación*/
            
            Console.WriteLine("Diga su nuemro en castellano entre 1 y 5");

            switch (Console.ReadLine().ToUpper())
            {

                case "UNO": Console.WriteLine("1"); break;
                case "DOS": Console.WriteLine("2"); break;
                case "TRES": Console.WriteLine("3"); break;
                case "CUATRO": Console.WriteLine("4"); break;
                case "CINCO": Console.WriteLine("5"); break;
                default: Console.WriteLine("NUMERO FUERA DEL RANGO"); break;
            }

            Console.ReadKey();
        }
    }
}

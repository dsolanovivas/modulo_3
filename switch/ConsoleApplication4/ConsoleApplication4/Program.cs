using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un valor entero entre 1 y 5. Luego mostrar en español el valor ingresado. 
             * Si se ingresa un valor fuera de dicho rango mostrar un mensaje indicando tal situación.*/
            Console.WriteLine("Diga su numero entre 1 y 5");
            
            switch (int.Parse(Console.ReadLine()))
            {
                case 1: Console.WriteLine("UNO"); break;
                case 2: Console.WriteLine("DOS"); break;
                case 3: Console.WriteLine("TRES"); break;
                case 4: Console.WriteLine("CUATRO"); break;
                case 5: Console.WriteLine("CINCO"); break;
                default: Console.WriteLine("NUMERO FUERA DEL RANGO"); break;
            }

            Console.ReadKey();
        }
    }
}

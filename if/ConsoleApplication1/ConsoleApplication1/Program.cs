using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete mostrar 
             * un mensaje "Promocionado".*/
            float nota1, nota2, nota3, suma,promedio;
            Console.WriteLine("Digite las nota 1");
            nota1=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite las nota 2");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite las nota 3");
            nota3 = float.Parse(Console.ReadLine());

            suma = nota1 + nota2 + nota3;
            promedio = suma / 3;
            if (promedio >= 3)
            {
                Console.WriteLine("Promocionado con: "+promedio);
            }
            else
            {
                Console.WriteLine("No Promocionado con: " + promedio);
            }

            Console.ReadLine();

        }
    }
}

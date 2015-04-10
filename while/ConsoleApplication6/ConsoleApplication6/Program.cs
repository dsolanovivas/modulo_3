using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que permita la carga de n valores por teclado y nos muestre 
             * posteriormente la suma de los valores ingresados y su promedio.*/
            int cont,sum,n;
            cont = 1;
            sum = 0;
            Console.WriteLine("Digite la cantidad de digitos ");
            n = int.Parse(Console.ReadLine());
            while (cont<=n)
            {
                Console.WriteLine("Digite numero");
                sum = sum + int.Parse(Console.ReadLine());
                cont++;
            }

            Console.WriteLine("el promedio de los numero es : "+(sum/cont));
            Console.ReadKey();
        }
    }
}

using System;

namespace SumayPromediotodosAppXamari
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double n1,n2,n3,n4;
			Console.WriteLine ("Calcular e informar la suma y promedio de cuatro numeros");
			Console.WriteLine ("Diga los cuatro numeros");
			n1 = Double.Parse (Console.ReadLine ());
			n2 = Double.Parse(Console.ReadLine ());
			n3 = Double.Parse(Console.ReadLine ());
			n4 = Double.Parse(Console.ReadLine ());
			Console.WriteLine ("La suma es de " +(n1+n2+n3+n4));
			Console.WriteLine ("El promedio es de " + ((n1+n2+n3+n4)/4));
			Console.ReadKey ();
		}
	}
}

using System;

namespace SumaYpromedioAppXamari
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double S,P;
			Console.WriteLine ("Calcular e informar la suma de los dos primeros y "+
				               "el producto del tercero y el cuarto.");
			Console.WriteLine ("Diga los cuatro numeros");
			S = Double.Parse(Console.ReadLine ())+Double.Parse(Console.ReadLine ());
			P = Double.Parse(Console.ReadLine ())*Double.Parse(Console.ReadLine ());
			Console.WriteLine ("La suma es de " + S);
			Console.WriteLine ("El producto es de " + P);
			Console.ReadKey ();
		}
	}
}

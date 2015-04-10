using System;

namespace PerimetroCuadradoAppXamari
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double P;
			Console.WriteLine ("Programa Calcular el perimtro de un cuadrdo");
			Console.WriteLine ("Diga el lado de un cuadrado");
			P = double.Parse(Console.ReadLine ()) * 4;
			Console.WriteLine ("El Perimitro del cuadrado es " + P);
			Console.ReadKey ();
		}
	}
}

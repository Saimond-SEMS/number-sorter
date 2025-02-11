  using System;

namespace itla2sorter
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int maxNumbers = 10;
			int[] listaNumeros = new int[maxNumbers];

			// pedir numeros

			for (int i = 0; i < maxNumbers; i++)
			{
				Console.WriteLine("Escribe 1 numero.");
				listaNumeros[i] = int.Parse(Console.ReadLine());
				Console.Clear();
			}


			//Ordenar numeros
			
			int buffer = 0;

			for (int i1 = 0; i1 < maxNumbers; i1++)
			{
				for (int i2 = i1; i2 < maxNumbers; i2++)
				{
					if (listaNumeros[i1] > listaNumeros[i2])
					{
						buffer = listaNumeros[i1];
						listaNumeros[i1] = listaNumeros[i2];
						listaNumeros[i2] = buffer;
					}
				}
			}
			
			//	mensaje de despedida

			Console.WriteLine("Esta es la lista de numeros ordenados");
			for (int i = 0; i < maxNumbers; i++)
			{
				Console.Write(listaNumeros[i]);
				Console.Write(" ");
			}
		}
	}
}
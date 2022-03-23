using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01_programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//Numeros enteros
			byte num1 = 30; // definicion y asignacion
			ushort num2 = 20000;
			int num3 = 50000;
			long num4; //Definicion
			num4 = 6000000;

			Console.WriteLine("El numero 1 es: " + num1);
			Console.WriteLine("El numero 2 es: " + num2);
			Console.WriteLine("El numero 3 es: " + num3);
			Console.WriteLine("El numero 4 es: " + num4);

			// Numeros decimales
			float peso = (float)50.5;
			double altura = 1.75;
			decimal promedio = (decimal)5.89;

			Console.WriteLine("El peso es: " + peso);
			Console.WriteLine("La altura es: " + altura);
			Console.WriteLine("El promedio es: " + promedio);

			// Caracteres

			char genero = 'M';
			bool esAprendiz = true;

			Console.WriteLine("Genero> " + genero);
			Console.WriteLine("Es aprendiz> " + esAprendiz);

			// Strings
			string nombre = "Anaelsa Rodriguez";
			string direccion = "calle 5 # 3 - 123";

			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Direccion: " + direccion);

			Console.ReadKey(true);
		}
    }
}

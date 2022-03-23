using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02_programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre; //Definir o declarar variable
            Console.WriteLine("Digite su nombre"); // Se muestra mensaje al usuario
            nombre = Console.ReadLine(); // Se captura el dato del usuario

            Console.WriteLine("Su nombre es {0}", nombre);
            //---------------------------------------------------------------
            // INT
            int edad;
            Console.WriteLine("Cual es su edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Su edad es {0}", edad);
            //----------------------------------------------------------------
            // Double
            double peso;
            Console.WriteLine("Cuanto pesa usted");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Su peso es {0}", peso);


            Console.ReadKey();
        }
    }
}

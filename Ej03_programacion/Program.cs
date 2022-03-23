using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03_programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 06.Algoritmo que lea el nombre de un articulo,la cantidad a comprar, el valor unitario 
            y muestre el nombre y el total a pagar*/
            string articulo;
            int cantidad;
            double valor, total;

            Console.WriteLine("Que articulo va a comprar");
            articulo = Console.ReadLine();

            Console.WriteLine("Cuantos va a comprar");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el valor unitario de este articulo");
            valor = double.Parse(Console.ReadLine());

            total = valor * cantidad;

            Console.WriteLine("Usted va a comprar {0} y el total a pagar es {1}", articulo, total);

            /* 07.Hacer un algoritmo para leer dos numeros los cuales seran tecleados por el usuario*/
            double num1;
            double num2;
            double resultado;

            Console.WriteLine("Digite el primer numero");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            num2 = double.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("el resultado de sumar {0} + {1} es {2} ", num1, num2, resultado);

            /*8. Hacer un algoritmo que lea el nombre de una persona y número de horas que estudia en la semana.*/
            string nombre;
            double hrs_estud;

            Console.WriteLine("Cual es su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Cuantas horas estudia a la semana");
            hrs_estud = double.Parse(Console.ReadLine());

            Console.WriteLine("Usted se llama {0} y estudia {1} horas a la semana" , nombre , hrs_estud);

            /*9. Hacer un algoritmo que lea el nombre de un estudiante, la cantidad de materias perdidas y la cantidad
            de materias ganadas.*/
            string nombre_estud;
            int mater_perd;
            int mater_gana;

            Console.WriteLine("Cual es su nombre");
            nombre_estud = Console.ReadLine();

            Console.WriteLine("Cuantas materias perdio");
            mater_perd = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuantas materias gano");
            mater_gana = int.Parse(Console.ReadLine());

            Console.WriteLine("Su nombre es {0}, perdio {1} materias y gano {2}" , nombre_estud , mater_perd , mater_gana);

            /*10. Hacer un algoritmo que lea el alto y el ancho de un rectángulo 
            y muestre su área y su perímetro. */

            double alto;
            double ancho;
            double area;
            double perimetro;

            Console.WriteLine("digite el valor para el alto del rectangulo");
            alto = double.Parse(Console.ReadLine());

            Console.WriteLine("digite el valor para el ancho del rectangulo");
            ancho = double.Parse(Console.ReadLine());

            area = ancho * alto;
            perimetro = (ancho + alto)*2;
            
            Console.WriteLine("el area del rectangulo es {0}" , area);
            Console.WriteLine("el perimetro del rectangulo es {0}" , perimetro);

            /*11. Hacer un algoritmo que lea dos números enteros A y B y muestre su diferencia.*/

            int num1;
            int num2;
            int total;

            Console.WriteLine("Digite un primer numero entero cualquiera");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite un segundo numero entero cualquiera");
            num2 = int.Parse(Console.ReadLine());

            total = num1 - num2;
            
            Console.WriteLine("La diferencia de {0} - {1} es {2}" , num1 , num2 , total);
            
            /*12. Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada y el número de
            horas que trabajó. Se debe mostrar el nombre y el pago de la persona.*/

            string nombre;
            double valor_hora;
            double n_horas;
            double pago;

            Console.WriteLine("Cual es su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("digite el valor de la hora trabajada");
            valor_hora = double.Parse(Console.ReadLine());

            Console.WriteLine("digite el numero de horas que trabajo");
            n_horas = double.Parse(Console.ReadLine());

            pago = valor_hora * n_horas;
            
            Console.WriteLine("Su pago es de {0}" , pago);

            /*13. Pedir el radio de un círculo y calcular su área. A=PI*r^2.*/

            double radio;
            double area;

            Console.WriteLine("Digite el valor del radio de un circulo");
            radio = double.Parse(Console.ReadLine());

            area = Math.PI * radio^2;

            Console.WriteLine("El area del circulo es {0}" , area);

            /*14. Pedir el radio de una circunferencia y calcular su longitud.*/

            double radio;
            double longitud;

            Console.WriteLine("Digite el valor del radio de un circulo");
            radio = double.Parse(Console.ReadLine());

            longitud = 2 * Math.PI * radio;

            Console.WriteLine("La longitud del circulo es {0}" , longitud);

            /*15. Pedir el lado de un cuadrado, mostrar su área y su perímetro.*/

            double lado;
            double area;
            double perimetro;

            Console.WriteLine("Digite el valor para el lado de un cuadrado");
            lado = double.Parse(Console.ReadLine());

            area = lado * lado;

            Console.WriteLine("El area del cuadrado es {0}" , area);

            perimetro = lado * 4;

            Console.WriteLine("El perimetro del cuadrado es {0}" , perimetro);

            /*16. Calcular el área de un rectángulo de lados X e Y.0*/

            double ladoX;
            double ladoY
            double area;

            Console.WriteLine("Digite el valor para el lado X de un rectangulo");
            ladoX = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor para el lado X de un rectangulo");
            ladoY = double.Parse(Console.ReadLine());

            area = ladoY * ladoX;

            Console.WriteLine("El area del rectangulo es {0}" , area);

            Console.ReadKey();
        }
    }
}

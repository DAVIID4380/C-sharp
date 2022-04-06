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

            /*08. Hacer un algoritmo que lea el nombre de una persona y número de horas que estudia en la semana.*/
            string nombre;
            double hrs_estud;

            Console.WriteLine("Cual es su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Cuantas horas estudia a la semana");
            hrs_estud = double.Parse(Console.ReadLine());

            Console.WriteLine("Usted se llama {0} y estudia {1} horas a la semana" , nombre , hrs_estud);

            /*09. Hacer un algoritmo que lea el nombre de un estudiante, la cantidad de materias perdidas y la cantidad
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
            
            /*11. . Hacer un algoritmo que lea dos números enteros A y B y muestre su diferencia.*/
            
            int num1 , num2 , diferencia;

            Console.WriteLine("Digite el valor del primer número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor del segundo número");
            num2 = int.Parse(Console.ReadLine());

            diferencia = num1 - num2;

            Console.WriteLine("La diferencia entre {0} y {1} es: " , num1 , num2);

            /*12. Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada y el número de
            horas que trabajó. Se debe mostrar el nombre y el pago de la persona.*/

            string nombre;
            double val_hora , num_horas , pago;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el valor de la hora trabajada");
            val_hora = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de horas que trabajó");
            num_horas = double.Parse(Console.ReadLine());

            pago = num_horas * val_hora;

            Console.WriteLine("Su nombre es {0} y su pago es de: ${1} " , nombre , pago);

            /*13. Pedir el radio de un círculo y calcular su área. A=PI*r^2.*/

            double radio , area;

            Console.WriteLine("Digite el valor del radio de un circulo para calcular su área");
            radio = double.Parse(Console.ReadLine());

            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El área del circulo es {0} " , area);

            /*14. Pedir el radio de una circunferencia y calcular su longitud.*/

            double radio , longitud;

            Console.WriteLine("Digite el valor del radio de un circulo para calcular su longitud");
            radio = double.Parse(Console.ReadLine());

            longitud = 2 * Math.PI * radio;

            Console.WriteLine("La longitud del circulo es {0} " , longitud);

            /*15. Pedir el lado de un cuadrado, mostrar su área y su perímetro.*/

            double lado , area , perimetro;

            Console.WriteLine("Digite el valor del lado de un cuadrado");
            lado = double.Parse(Console.ReadLine());

            area = lado * lado;
            perimetro = lado * 4;

            Console.WriteLine("El área del cuadrado es {0} y el perímetro es {1}" , area , perimetro);

            /*16. Calcular el área de un rectángulo de lados X e Y.*/

            double ladoX , ladoY , area;

            Console.WriteLine("Digite el valor del lado X de un rectángulo");
            ladoX = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor del lado Y de un rectángulo");
            ladoY = double.Parse(Console.ReadLine());

            area = ladoX * ladoY;

            Console.WriteLine("El área del rectángulo es {0}" , area);

            /*17. Pedir dos números y decir si son iguales o no.*/

            double num1 , num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Estos números son iguales");
            }
            else
            {
                Console.WriteLine("Estos números son diferentes");
            }

            /*18. Pedir un número e indicar si es positivo o negativo.*/

            double num;

            Console.WriteLine("Digite un número cualquiera");
            num = double.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Este número es positivo");
            }
            else 
            {
                Console.WriteLine("Este número es negativo");
            }

            /*19. Pedir dos números y decir si uno es múltiplo del otro.*/

            double num1 , num2 , resultado;

            Console.WriteLine("Digite un numero cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro numero cualquiera");
            num2 = double.Parse(Console.ReadLine());

            resultado = num1 * num2;

            Console.WriteLine("{0} multiplicado {1} es {2}" , num1 , num2 , resultado);

            if (resultado % num1 = 0)
            {
                Console.WriteLine("{0} es múltiplo de {1} y {2}" , resultado , num1 , num2);
            }
            else
            {
                Console.WriteLine("{0} no es múltiplo de {1} y {2}" , resultado , num1 , num2);
            }

            /*20. Pedir dos números y decir cuál es el mayor.*/

            double num1 , num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("{0} es mayor que {1}" , num1 , num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("{0} y {1} son iguales" , num1 , num2);
            }
            else
            {
                Console.WriteLine("{0} es mayor que {1}" , num2 , num1);
            }

            /*21. Pedir dos números y decir cuál es el mayor o si son iguales.*/

            double num1 , num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("{0} es mayor que {1}" , num1 , num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("{0} y {1} son iguales" , num1 , num2);
            }
            else
            {
                Console.WriteLine("{0} es mayor que {1}" , num2 , num1);
            }

            /*22. Pedir dos números y mostrarlos ordenados de mayor a menor.*/

            double num1 , num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1}" , num1 , num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("{0} y {1} son iguales" , num1 , num2);
            }
            else
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1}" , num2 , num1);
            }

            /*23. Pedir tres números y mostrarlos ordenados de mayor a menor.*/

            double num1 , num2 , num3;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 > num3)
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1} , {2}" , num1 , num2 , num3);
            }
            else if (num1 == num2 == num3)
            {
                Console.WriteLine("{0} , {1} y {2} son iguales" , num1 , num2 , num3);
            }
            else
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1} , {2}" , num3 , num2 , num1);
            }
            
             /*.25. Pedir una nota de 0 a 5 y mostrarla de la forma: Insuficiente (0 – 2,9), Suficiente (3 – 4,5) y Bien (4,6 – 5)*/

            double nota;

            Console.WriteLine("Digite el valor de la nota");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 0 && nota < 3)
            {
                Console.WriteLine("La nota es insuficiente");
            }
            else if (nota >= 3 && nota < 4.6)
            {
                Console.WriteLine("La nota es suficiente");
            }
            else if (nota >= 4.6 && nota <= 5)
            {
                Console.WriteLine("La nota es bien");
            }
            else
            {
                Console.WriteLine("Rango incorrecto");
            }
            
            Console.ReadKey();
        }
    }
}

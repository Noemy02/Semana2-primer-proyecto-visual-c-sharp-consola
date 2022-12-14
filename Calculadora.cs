using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_primer_proyecto_visual_c_sharp_consola
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            // Declarar variables y luego inicializar a cero.
            double num1 = 0; double num2 = 0;

            // Mostrar el título como la aplicación de calculadora de la consola C#.
            Console.WriteLine("Consola Calculadora en C#\r");
            Console.WriteLine("------------------------\n");

            // Pida al usuario que escriba el primer número.
            Console.WriteLine("Escriba un número, y luego presione Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Pida al usuario que escriba el segundo número.
            Console.WriteLine("Escriba otro número, y luego presione Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Pídale al usuario que elija una opción.
            Console.WriteLine("Elija una opción de la siguiente lista:");
            Console.WriteLine("\ts - Sumar");
            Console.WriteLine("\tr - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write(" ¿Su opcion? ");

            // Use una declaración de cambio para hacer los cálculos.
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"Tu resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "r":
                    Console.WriteLine($"Tu resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    //Pida al usuario que ingrese un divisor distinto de cero hasta que lo haga.
                    while (num2 == 0)
                    {
                        Console.WriteLine("Introduzca un divisor distinto de cero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Tu resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Espere a que el usuario responda antes de cerrar.
            Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola Calculadora...");
            Console.ReadKey();
        }
    }
}

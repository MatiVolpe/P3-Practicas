using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio4 : IPractica1
    {
        public void Ejecutar()
        {
            //4) Pedir dos números al usuario por teclado y decir qué número es el mayor.

            double num1, num2;
            Console.WriteLine("Ingrese dos números para saber cual es el mayor");
            Console.WriteLine("Ingrese el primer número");
            while(double.TryParse(Console.ReadLine(), out num1) == false)
            {
                Console.WriteLine("No es un valor numérico, intente nuevamente");
            }
            Console.WriteLine("Ingrese el segundo número");
            while (double.TryParse(Console.ReadLine(), out num2) == false)
            {
                Console.WriteLine("No es un valor numérico, intente nuevamente");
            }
            if (num1 == num2)
            {
                Console.WriteLine("Ambos números son iguales");
            }
            else
            {
                if (num1 < num2)
                {
                    Console.WriteLine($"El número más grande es el segundo: {num2}");
                }
                else
                {
                    Console.WriteLine($"El número más grande es el primero: {num1}");
                }
            }
        }
    }
}

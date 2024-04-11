using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio1 : IPractica1
    {
        public void Ejecutar()
        {
            //1) Crear 3 variables numéricas con el valor que quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.

            int a = 4, b = 2, c = 5;
            int d = a + b + c;

            Console.WriteLine($"La suma es {d}");
        }
    }
}

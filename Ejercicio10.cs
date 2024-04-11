using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    internal class Ejercicio10 : IPractica1
    {
        public void Ejecutar()
        {
            //10) Recorrer los números del 1 al 100. Crear 2 listas, una con los números pares y otra con los divisibles entre 3.
            //Mostrar las 2 listas.

            int i;
            var pares = new List<int>();
            var divTres = new List<int>();

            for (i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    pares.Add(i);
                }
                if (i % 3 == 0) 
                { 
                    divTres.Add(i);
                }
            }
            Console.WriteLine("Lista de números pares:");
            foreach (var  num in pares)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n\nLista de números divisibles por tres");
            foreach (var num in divTres)
            {
                Console.WriteLine(num);
            }
        }
    }
}

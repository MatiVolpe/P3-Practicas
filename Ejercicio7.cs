using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio7 : IPractica1
    {
        public void Ejecutar()
        {
            //7) Recorrer los números del 1 al 100. Usar un bucle for.

            int i;
            for (i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

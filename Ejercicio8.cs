using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio8 : IPractica1
    {
        public void Ejecutar()
        {
            //8) Recorrer los números del 1 al 100. Usar un bucle while.

            int i=1;
            while (i < 101)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

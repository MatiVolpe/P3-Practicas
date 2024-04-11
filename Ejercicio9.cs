using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio9 : IPractica1
    {
        public void Ejecutar()
        {
            //9) Recorrer los números del 1 al 100. Mostrar los números pares. Usar el tipo de bucle que quieras.

            int i;
            for (i = 2; i < 101; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}

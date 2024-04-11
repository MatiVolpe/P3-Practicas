using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    internal class LINQEj1 : IPractica1
    {
        public void Ejecutar()
        {
            //1) Dada una lista de números enteros, escriba una consulta que devuelva la lista de números mayores que 30 y menores que 100.
            //Ejemplo: [67, 92, 153, 15] → 67, 92


            List<int> enteros= new List<int>();

            enteros.Add(67);
            enteros.Add(92);
            enteros.Add(153);
            enteros.Add(15);

            //Por query expressions
            var resultado = from ent in enteros
                            where ent > 30 && ent<100
                            orderby ent descending
                            select ent;

            //Por methods
            var resultado2 = enteros.Where(x => x > 30 && x < 100).OrderByDescending(x => x).ToList();

            foreach (var ent in resultado)
            {
                Console.WriteLine(ent);
            }

            Console.WriteLine("\n----------\n");

            foreach (var ent in resultado2)
            {
                Console.WriteLine(ent);
            }

        }
    }
}

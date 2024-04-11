using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio3 : IPractica1
    {
        public void Ejecutar()
        {
            // 3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: “Te llamas ” <nombre> ” y
            // tienes ” <años> ” años”

            string? nombre;
            int edad;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            int.TryParse(Console.ReadLine(), out edad);
            Console.WriteLine($"Te llamas {nombre} y tienes {edad} años");
        }
    }
}

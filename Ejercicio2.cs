using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio2 : IPractica1
    {
        public void Ejecutar()
        {
            //2) Pedir por parámetro un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) y mostrar por consola
            //el siguiente mensaje “Hola ” <nombre> ” bienvenido a ” <ciudad>”. Utilizar Interpolación.

            string? nomPersona, nomCiudad;
            Console.WriteLine("Ingrese el nombre de la persona");
            nomPersona = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la ciudad");
            nomCiudad = Console.ReadLine();

            Console.WriteLine($"Hola {nomPersona} bienvenido a {nomCiudad}");
        }
    }
}

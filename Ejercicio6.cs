using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio6 : IPractica1
    {
        public void Ejecutar()
        {
            //6) Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta)
            //si la forma de pago es mediante tarjeta, pedir el número de la misma(inventado), verificar que sean 16 dígitos
            //e informar el valor a pagar con un 10% de recargo.

            string? numTarjeta;
            int opc;
            double precio;

            Console.WriteLine("Ingrese el valor del producto");
            double.TryParse(Console.ReadLine(), out precio);
            while (precio < 0)
            {
                Console.WriteLine("El precio del producto debe ser mayor que cero, vuelva a ingresar el valor");
                double.TryParse(Console.ReadLine(), out precio);
            }
            Console.WriteLine("Seleccione una de las siguientes opciones:\n 1. Efectivo\n2. Tarjeta");
            int.TryParse(Console.ReadLine(), out opc);
            while (opc != 1 && opc != 2)
            {
                Console.WriteLine("Las opciones disponibles son:\n 1. Efectivo\n2. Tarjeta\nIntente nuevamente");
                int.TryParse(Console.ReadLine(), out opc);
            }
            if (opc == 1)
            {
                Console.WriteLine($"El precio a pagar en efectivo es de {precio}");
            }
            else
            {
                Console.WriteLine("Ingrese los 16 dígitos de su tarjeta");
                numTarjeta = Console.ReadLine();
                while (numTarjeta.Length != 16)
                {
                    Console.WriteLine("La cantidad de dígitos no es correcta, intente nuevamente");
                    numTarjeta = Console.ReadLine();
                }
                precio = precio * 1.1;
                Console.WriteLine($"El valor a pagar con tarjeta es de {precio}");
            }
        }
    }
}

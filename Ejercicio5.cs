using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio5 : IPractica1
    {
        public void Ejecutar()
        {
            //5) Pedir el nombre del día al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo.Se debe
            //poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” /            “  lunes” y debería funcionar.
            //TIP para investigar: Trim() y StringComparison.OrdinalIgnoreCase

            string? nameDay, nameDayTrim;
            Console.WriteLine("Ingrese un dia de la semana para saber si es fin de semana o no");
            nameDay = Console.ReadLine();
            nameDayTrim = nameDay.Trim();
            if (nameDayTrim.Equals("lunes", StringComparison.OrdinalIgnoreCase) ||
                nameDayTrim.Equals("martes", StringComparison.OrdinalIgnoreCase) ||
                nameDayTrim.Equals("miercoles", StringComparison.OrdinalIgnoreCase) ||
                nameDayTrim.Equals("miércoles", StringComparison.OrdinalIgnoreCase) ||
                nameDayTrim.Equals("jueves", StringComparison.OrdinalIgnoreCase) ||
                nameDayTrim.Equals("viernes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No es un dia de fin de semana");
            }
            else
            {
                if (nameDayTrim.Equals("sábado", StringComparison.OrdinalIgnoreCase) ||
                    nameDayTrim.Equals("sabado", StringComparison.OrdinalIgnoreCase) ||
                    nameDayTrim.Equals("domingo", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Es un dia del fin de semana");
                }

                else
                {
                    Console.WriteLine("El valor ingresado no es un día");
                }
            }

        }
    }
}

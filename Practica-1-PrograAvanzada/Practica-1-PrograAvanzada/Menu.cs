using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_PrograAvanzada
{
    internal class Menu
    {
        public void mostrarMenu()
        {
            while (true)
            {
                Console.WriteLine("Menu Hoteles \n" +
                    "1- Listar Hoteles  \n" +
                    "2- Listar habitaciones disponibles por hotel ?\n" +
                    "3- Registrar reservación a cliente automáticamente \n" +
                    "4- Registrar reservación a cliente manualmente \n" +
                    "5- Eliminar reservación ?\n" +
                    "6- Eliminar todas las reservaciones por hotel ?\n" +
                    "7- Buscar persona por número de cédula o pasaporte \n" +
                    "8- Validar disponibilidad de habitación en hotel \n" +
                    "9- Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Opcion 1");
                        break;
                    case "2":
                        Console.WriteLine("Opcion 2");
                        break;
                    case "3":
                        Console.WriteLine("Opcion 3");
                        break;
                    case "4":
                        Console.WriteLine("Opcion 4");
                        break;
                    case "5":
                        Console.WriteLine("Opcion 5");
                        break;
                    case "6":
                        Console.WriteLine("Opcion 6");
                        break;
                    case "7":
                        Console.WriteLine("Opcion 7");
                        break;
                    case "8":
                        Console.WriteLine("Opcion 8");
                        break;
                    case "9":
                        Console.WriteLine("Hasta luego");
                        return;
                    default:
                        Console.WriteLine("Incorrecto");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}



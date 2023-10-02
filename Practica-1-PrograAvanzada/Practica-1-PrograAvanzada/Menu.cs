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
        Persona persona = new Persona("Jose", "Gonzalez", "Montoya", "2-2684-0694", "josedaniel@gmail.com", "costarricense", 89569416, 0);
        Hoteles hotelNewYork = new Hoteles("Hotel New York", 2, 3, 4);
        Hoteles hotelRoma = new Hoteles("Hotel Continental de Roma", 2, 5, 50);
        Hoteles hotelMarruecos = new Hoteles("Hotel Continental de Marruecos", 2, 6, 53);
        Hoteles hotelTokio = new Hoteles("Hotel Continental de Osaka Tokio", 2, 6, 45);
        int contadorHotelNewYork;
        int contadorHotelRoma;
        int contadorMarruecos;
        int contadorTokio;

        

        public void MostrarMenu()
        {
            //Declaracion de objetos

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
                        Console.WriteLine(hotelNewYork.getNombre());
                        Console.WriteLine(hotelRoma.getNombre());
                        Console.WriteLine(hotelMarruecos.getNombre());
                        Console.WriteLine(hotelTokio.getNombre());
                        break;
                    case "2":
                        subMenuOpcion2();
                        break;
                    case "3":
                        Console.WriteLine("Opcion 3");
                        break;
                    case "4":
                        Console.WriteLine("Opcion 4");
                        Console.WriteLine("Ingrese el nombre de hotel: ");
                        String nombreHotel = Console.ReadLine();
                        switch (nombreHotel)
                        {
                            case "Hotel New York":
                                Console.WriteLine("Ingrese el numero de torre");
                                String numTorre = Console.ReadLine();
                                int.TryParse(numTorre, out int numeroTorre);
                                Console.WriteLine("Ingrese el numero de piso");
                                String numPiso = Console.ReadLine();
                                int.TryParse(numPiso, out int numeroPiso);
                                Console.WriteLine("Ingrese el numero de habitacion");
                                String numHabitacion = Console.ReadLine();
                                int.TryParse(numHabitacion, out int numeroHabitacion);

                                // se verifica la disponibilidad
                                if (hotelNewYork.HabitacionDisponible(numeroTorre, numeroPiso, numeroHabitacion))
                                {
                                    // se asigna la habitacion
                                    hotelNewYork.GetPisosHabitaciones()[numeroTorre, numeroPiso, numeroHabitacion] = 1; // 1 indica que la habitación está ocupada
                                    Console.WriteLine("Asignación correcta en la habitación correspondiente.");
                                }
                                else
                                {
                                    Console.WriteLine("La habitación se encuentra ocupada.");
                                }
                                break;

                            case "Hotel Continental de Roma":

                                break;
                            case "Hotel Continental de Marruecos":

                                break;

                            case "Hotel Continental de Osaka Tokio":
                                break;

                            default:
                                Console.WriteLine("El hotel seleccionado no existe");
                                break;
                        }

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

        private void subMenuOpcion2()
        {
            while (true)
            {
                Console.WriteLine("Submenú #1 \n" +
                    "1- Listar Hotel Continental de New York\n" +
                    "2- Listar Hotel Continental de Roma\n" +
                    "3- Listar Hotel Continental de Marruecos\n" +
                    "4- Listar Hotel Continental de Osaka Tokyo\n" +
                    "5- Listar todos los hoteles\n" +
                    "6- Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Listar Hotel Continental de New York");
                        ;
                        for (int i = 0; i < hotelNewYork.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorHotelNewYork++;
                            Console.WriteLine("Habitacion numero " + contadorHotelNewYork + ": Disponible");
                        }
                        for (int i = 0; i < hotelNewYork.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorHotelNewYork--;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Listar Hotel Continental de Roma");
                        for (int i = 0; i < hotelRoma.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorHotelRoma++;
                            Console.WriteLine("Habitacion numero " + contadorHotelRoma + ": Disponible");
                        }
                        for (int i = 0; i < hotelRoma.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorHotelRoma--;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Listar Hotel Continental de Marruecos");
                        for (int i = 0; i < hotelMarruecos.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorMarruecos++;
                            Console.WriteLine("Habitacion numero " + contadorMarruecos + ": Disponible");
                        }
                        for (int i = 0; i < hotelMarruecos.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorMarruecos--;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Listar Hotel Continental de Osaka Tokyo");
                        for (int i = 0; i < hotelTokio.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorTokio++;
                            Console.WriteLine("Habitacion numero " + contadorTokio + ": Disponible");
                        }
                        for (int i = 0; i < hotelTokio.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorTokio--;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Listar todos los hoteles");
                        Console.WriteLine("Hotel Continental New York");
                        for (int i = 0; i < hotelNewYork.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorHotelNewYork++;
                            Console.WriteLine("Habitacion numero " + contadorHotelNewYork + ": Disponible");
                        }
                        for (int i = 0; i < hotelNewYork.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorHotelNewYork--;
                        }
                        Console.WriteLine("----------------------------------------------------------------------");

                        Console.WriteLine("Hotel Continental de Roma");
                        for (int i = 0; i < hotelRoma.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorHotelRoma++;
                            Console.WriteLine("Habitacion numero " + contadorHotelRoma + ": Disponible");
                        }
                        for (int i = 0; i < hotelRoma.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorHotelRoma--;
                        }
                        Console.WriteLine("----------------------------------------------------------------------");

                        Console.WriteLine("Hotel Continental de Marruecos");
                        for (int i = 0; i < hotelMarruecos.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorMarruecos++;
                            Console.WriteLine("Habitacion numero " + contadorMarruecos + ": Disponible");
                        }
                        for (int i = 0; i < hotelMarruecos.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorMarruecos--;
                        }
                        Console.WriteLine("----------------------------------------------------------------------");

                        Console.WriteLine("Hotel Continental de Osaka Tokio");
                        for (int i = 0; i < hotelTokio.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorTokio++;
                            Console.WriteLine("Habitacion numero " + contadorTokio + ": Disponible");
                        }
                        for (int i = 0; i < hotelTokio.GetPisosHabitaciones().GetLength(2); i++)
                        {
                            contadorTokio--;
                        }
                        break;

                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}


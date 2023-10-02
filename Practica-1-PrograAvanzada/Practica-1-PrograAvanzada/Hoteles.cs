using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_PrograAvanzada
{
    internal class Hoteles
    {
        String nombre;
        private int[,,] pisosHabitaciones; //Se declara un arreglo multidimensional     
        public Hoteles(String nombre, int torre, int numPisos, int numHabitacion)
        {
            this.nombre = nombre;
            pisosHabitaciones = new int[torre, numPisos, numHabitacion];
        }
        
        public String getNombre()
        {
            return nombre;
        }

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public int[,,] GetPisosHabitaciones()
        {
            return pisosHabitaciones;
        }

        public void SetPisosHabitaciones(int[,,] nuevosPisosHabitaciones)
        {
            pisosHabitaciones = nuevosPisosHabitaciones;
        }

        public bool HabitacionDisponible(int torre, int piso, int habitacion)
        {
            // verifica las coordenadas
            if (torre >= 0 && torre < pisosHabitaciones.GetLength(0) &&
                piso >= 0 && piso < pisosHabitaciones.GetLength(1) &&
                habitacion >= 0 && habitacion < pisosHabitaciones.GetLength(2))
            {
                // esta disponible
                return pisosHabitaciones[torre, piso, habitacion] == 0; 
            }
            else
            {
                // No esta dentro del arreglo multidimensional
                Console.WriteLine("Coordenadas fuera de los límites del arreglo.");
                return false;
            }
        }

    }
}
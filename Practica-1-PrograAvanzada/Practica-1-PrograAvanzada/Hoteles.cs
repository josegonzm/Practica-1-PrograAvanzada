using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_PrograAvanzada
{
    internal class Hoteles
    {
        String torres;
        int[][] pisosHabitaciones;

        public Hoteles() 
        {
            this.torres = "";
            this.pisosHabitaciones = null;
        }

        public Hoteles(string torres, int[][] pisos)
        {
            this.torres = torres;
            this.pisosHabitaciones = pisos;
        }

        public string Torres
        {
            get { return torres; }
            set { torres = value; }
        }

        
    }
}

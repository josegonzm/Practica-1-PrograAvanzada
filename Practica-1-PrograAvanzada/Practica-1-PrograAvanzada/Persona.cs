using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_PrograAvanzada
{
    internal class Persona
    {
        private String nombre;
        private String primerApellido;
        private String segundoApellido;
        private String id;
        private String correo;
        private String nacionalidad;
        private int telefono;
        private String habitacion;

        public Persona()
        {
            this.nombre = "";
            this.primerApellido = "";
            this.segundoApellido = "";
            this.id = "";
            this.correo = "";
            this.nacionalidad = "";
            this.telefono = 0;
            this.habitacion = "";
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }

        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }
    }
}


using System;
using System.Globalization;

namespace CAI_02EjercicioAgenda
{
    class Contacto
    {

        //Variables de clase
        string _nombre;
        string _apellido;
        string _direccion;
        string _telefono;
        string _email;
        int _diaNac;
        int _mesNac;
        int _añoNac;


        //Propiedades de clase
        public string Nombre
        {
            get { return this._nombre; }
        }

        public string Apellido
        {
            get { return this._apellido; }
        }

        public string Direccion
        {
            get { return this._direccion; }
        }

        public string Telefono
        {
            get { return this._telefono; }
        }

        public string Email
        {
            get { return this._email; }
        }

        public string FechaNacimiento
        {
            get
            {
                return this._diaNac + "/" + this._mesNac + "/" + this._añoNac;
            }
        }




        //Constructor de clase

        internal Contacto(Contacto contacto)
        {
            this._nombre = contacto._nombre;
            this._apellido = contacto._apellido;
            this._email = contacto._email;
            this._direccion = contacto._email;
            this._diaNac = contacto._diaNac;
            this._mesNac = contacto._mesNac;
            this._añoNac = contacto._añoNac;
        }


        /// <summary>
        /// Cómo mínimo un contacto debe tener Nombre, Apellido y Email
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        internal Contacto(string nombre, string apellido, string email)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._email = email;
        }



        //Métodos de clase

        public void ActualizarNombre(string nombre)
        {
            this._nombre = nombre;
        }

        public void ActualizarApellido(string apellido)
        {
            this._apellido = apellido;
        }

        public void ActualizarEmail(string email)
        {
            this._email = email;
        }

        public void ActualizarDireccion(string direccion)
        {
            this._direccion = direccion;
        }

        public void ActualizarFechaNacimiento(int dia, int mes, int año)
        {
            this._diaNac = dia;
            this._mesNac = mes;
            this._añoNac = año;
        }

    }
}

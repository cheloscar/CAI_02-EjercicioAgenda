using System;
using System.Globalization;

namespace CAI_02EjercicioAgenda
{
    public class Contacto
    {

        //Variables de clase
        int _id;
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

        public int ID
        {
            get { return this._id; }
        }




        //Constructor de clase

        internal Contacto(Contacto contacto, int id)
        {
            this._nombre = contacto.Nombre;
            this._apellido = contacto.Apellido;
            this._email = contacto.Email;
            this._direccion = contacto.Direccion;
            this._diaNac = contacto._diaNac;
            this._mesNac = contacto._mesNac;
            this._añoNac = contacto._añoNac;
            this._id = id;
        }


        /// <summary>
        /// Cómo mínimo un contacto debe tener Nombre, Apellido y Email
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        internal Contacto(string nombre, string apellido, string email, int id)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._email = email;
            this._id = id;
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

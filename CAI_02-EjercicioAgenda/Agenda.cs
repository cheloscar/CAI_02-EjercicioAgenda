using System;
using System.Collections.Generic;

namespace CAI_02EjercicioAgenda
{
    class Agenda
    {
        //Variables de clase
        int _capacidad;
        string _tipo;
        string _propietario;
        List<Contacto> _listaContactos;


        //Propiedades de clase
        public int Capacidad
        {
            get { return this._capacidad; }
        }

        public string Tipo
        {
            get { return this._tipo; }
        }

        public string Propietario
        {
            get { return this._propietario; }
        }



        //Constructor de clase
        internal Agenda(int capacidad, string tipo, string propietario)
        {
            this._capacidad = capacidad;
            this._tipo = tipo;
            this._propietario = propietario;
            this._listaContactos = new List<Contacto>();
        }




        //Métodos de clase

        /// <summary>
        /// Con este método se agrega un contacto a la Agenda. Se verifica que no se exceda la Capacidad.
        /// No devuelve error.
        /// </summary>
        /// <param name="contacto"></param>
        public void AgregarContacto(Contacto contacto)
        {
            if (this._listaContactos.Count < this._capacidad)
            {
                this._listaContactos.Add(contacto);
            }
        }

        /// <summary>
        /// Se busca el "texto" en los campos Nombre, Apellido, Dirección e Email.
        /// </summary>
        /// <param name="campo"></param>
        /// <param name="texto"></param>
        /// <returns>Devuelve una lista con las coincidencias, vacía si no hubo coincidencias</returns>
        public List<Contacto> BuscarContacto(string campo, string texto)
        {
            List<Contacto> resultados = new List<Contacto>();


            //Si el criterio de búsqueda 
            if (campo != "Nombre" && campo != "Apellido")
            {
                return resultados;
            }

            foreach (Contacto contacto in this._listaContactos)
            {
                if (contacto.Nombre.Contains(texto)) { resultados.Add(contacto); }
                else if (contacto.Apellido.Contains(texto)) { resultados.Add(contacto); }
                else if (contacto.Direccion.Contains(texto)) { resultados.Add(contacto); }
                else if (contacto.Email.Contains(texto)) { resultados.Add(contacto); }
            }

            return resultados;
        }




    }
}

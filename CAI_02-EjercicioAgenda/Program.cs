using System;
using System.Collections.Generic;


namespace CAI_02EjercicioAgenda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string _propietario;
            int _capacidad;
            string _tipo;
            bool _continuar;
            Agenda _agenda;
            int _opcionMenu = 1;

            //Inicio del programa
            Menu.MenuBienvenida();

            //Solicitud de datos iniciales

            do
            {
                Console.WriteLine("A continuación ingrese la cantidad de registros que desea tener en su Agenda Digital.");
                Console.WriteLine("Recuerde que debe ser un número entero positivo mayor que cero e inferior a 100000.");
                Console.WriteLine("Cantidad de registros: ");

                if ((int.TryParse(Console.ReadLine(), out _capacidad)) == true && Complementos.ValidarLimites(_capacidad, 1, 100000) == true)
                {
                    Console.WriteLine("Valor aceptado.");
                    _continuar = false;
                }
                else
                {
                    Console.WriteLine("Ha ingresado un valor incorrecto. Se solicitarán de nuevos los datos.");
                    _continuar = true;
                }

            } while (_continuar);

            Console.WriteLine("A continuación ingrese un texto que describa el tipo de agenda.");
            Console.WriteLine("Tipo de agenda: ");

            _tipo = Console.ReadLine();

            Console.WriteLine("A continuación ingrese el nombre del propietario.");
            Console.WriteLine("Propietario: ");

            _propietario = Console.ReadLine();

            //Inicialización de la agenda

            _agenda = new Agenda(_capacidad, _tipo, _propietario);


            do
            {
                if (_opcionMenu == 1)
                {
                    Menu.MenuPrincipal();
                    Console.ReadKey();
                }




            } while (_continuar);



        }
    }
}

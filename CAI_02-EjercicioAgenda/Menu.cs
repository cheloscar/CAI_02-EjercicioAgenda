using System;
namespace CAI_02EjercicioAgenda
{
    public class Menu
    {
        public static void MenuBienvenida()
        {
            Console.WriteLine("***   Bienvenido a su AGENDA DIGITAL   ***");
            Console.WriteLine();
            Console.WriteLine("Continuación se le solictarán los datos para iniciar su agenda");
            Console.WriteLine("Presione cualquier tecla para comenzar...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("***   Menú principal de su agenda digital   ***");
            Console.WriteLine();
            Console.WriteLine("1 - Agregar un contacto");
        }
    }
}

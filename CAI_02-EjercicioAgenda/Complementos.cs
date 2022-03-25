using System;
namespace CAI_02EjercicioAgenda
{
    public class Complementos
    {
        public static bool ValidarLimites(int NRO, int MIN, int MAX)
        {
            if (NRO < MIN) return false;
            if (NRO > MAX) return false;
            else return true;
        }
    }
}

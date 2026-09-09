using System.Runtime.InteropServices.Marshalling;

namespace Recursividad.Logica
{
    public class Recursividades
    {
        public int CalcularFactorial(int num)
        {
            //caso base o condiciones de salida
            if (num == 1)
            {
                return 1;
            }

            //caso general
            return num * CalcularFactorial(num - 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp02.Exceptions;

namespace tp02
{
    public class Division
    {
        public static void DivTwoNumbers()
        {
            try
            {
                int numberOne;
                int numberTwo;


                Console.WriteLine("Ingrese el dividendo");
                numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el divisor");
                numberTwo = Convert.ToInt32(Console.ReadLine());
                divByZero.ThrowException(numberOne, numberTwo);

            }
            catch (Exception e)
            {
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Operacion finalizada");
            }
        }
    }
}

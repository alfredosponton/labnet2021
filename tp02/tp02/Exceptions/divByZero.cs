using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp02.Extensions;

namespace tp02.Exceptions
{
    public class divByZero
    {
        public static void ThrowCustomException()
        {
            throw new CustomException();
        }


        public static void ThrowException(int number, int divider)
        {

            try
            {

                int divideResult = number.Divide(divider);
                Console.WriteLine (divideResult);

            }
            catch (DivideByZeroException e)
            {
               Console.WriteLine ("Solo Chuck Norris divide por cero.\n {0}", e.Message);

            }
        }
    }
}

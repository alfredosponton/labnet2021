using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp02.Exceptions;
using tp02.Extensions;

namespace tp02
{
    class Program
    {
        static void Main(string[] args)
        {

            Division.DivTwoNumbers();

            try
            {
                divByZero.ThrowCustomException();
            }
            catch (CustomException e)
            {
                Console.WriteLine($"Se capturo la custom exception; '{e.Message}'");
            }
            finally
            {
                Console.WriteLine("Finalizó la custom exception");
            }
            Console.ReadKey();
        }
    }
}

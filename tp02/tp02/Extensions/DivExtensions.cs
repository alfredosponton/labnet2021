using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp02.Extensions
{
    public static class DivExtensions
    {
        public static int Divide(this int number, int divider)
        {
            return number / divider;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp02
{
    class CustomException : Exception
    {
        public CustomException() : base("Error de la CustomException")
        {

        }
    }
}

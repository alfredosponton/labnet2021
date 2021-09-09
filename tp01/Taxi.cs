using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {
        }
        public override string Avanzar()
        {
            return $"El taxi tiene {pasajeros} pasajeros y avanza";
        }

        public override string Detenerse()
        {
            return $"El taxi tiene {pasajeros} pasajeros y se detiene";
        }

        public override string Descripcion()
        {
            return $"Taxi";
        }

    }
}

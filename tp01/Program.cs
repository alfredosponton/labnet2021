using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("La cantidad de transportes elegidos deben ser 10");

            Console.WriteLine("Introduzca cantidad de omnibus");
            int cantidadOmnibus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca cantidad de taxis");
            int cantidadTaxi = Convert.ToInt32(Console.ReadLine());

            if (10 == cantidadOmnibus + cantidadTaxi)
            {

                List<TransportePublico> transportePublico = new List<TransportePublico>();

                for (int i = 0; i < cantidadOmnibus; i++)
                {
                    Console.WriteLine("Introduzca cantidad de pasajeros del Omnibus {0}", i + 1);
                    int pasajeros = Convert.ToInt32(Console.ReadLine());
                    transportePublico.Add(new Omnibus(pasajeros));
                }
                for (int i = 0; i < cantidadTaxi; i++)
                {
                    Console.WriteLine("Introduzca cantidad de pasajeros del taxi {0}", i + 1);
                    int pasajeros = Convert.ToInt32(Console.ReadLine());
                    transportePublico.Add(new Taxi(pasajeros));
                }

                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine("{0} {1}: Pasajeros: {2}", transportePublico[i].Descripcion(), i + 1, transportePublico[i].pasajeros);
                }

            }
            else
            {
                Console.WriteLine("Cantidad de transportes elegidos supera las 10 unidades. Vuelva a ejecutar");
            }

            Console.ReadLine();
        }
    }
}

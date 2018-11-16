using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            VehiculoFactory factory = new VehiculoFactory();

            IVehiculo vehiculoMoto = factory.CreateInstance("Moto");

            if (vehiculoMoto == null)
                return;

            IVehiculo vehiculoCarro = factory.CreateInstance("Carro");

            if (vehiculoCarro == null)
                return;

            IVehiculo vehiculoBus = factory.CreateInstance("Bus");

            if (vehiculoBus == null)
                return;

            Console.WriteLine(vehiculoMoto.ObtenerInfo());
            Console.WriteLine(vehiculoCarro.ObtenerInfo());
            Console.WriteLine(vehiculoBus.ObtenerInfo());
            Console.ReadLine();
        }
    }
}

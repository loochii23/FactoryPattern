using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Carro : IVehiculo
    {
        public string Nombre { get; set; }
        public int Puertas { get; set; }
        public int Ruedas { get; set; }
        public int Capacidad { get; set; }

        public string ObtenerInfo()
        {
            return "Soy " + Nombre + " tengo " + Puertas + " puertas, " + Ruedas + " ruedas y capacidad de " + Capacidad + " pasajeros";
        }
    }
}

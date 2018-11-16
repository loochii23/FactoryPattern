using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehiculo
    {
        string Nombre { get; set; }
        int Puertas { get; set; }
        int Ruedas { get; set; }
        int Capacidad { get; set; }

        string ObtenerInfo();
    }
}

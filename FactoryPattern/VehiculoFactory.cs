using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehiculoFactory
    {
        public IVehiculo CreateInstance(string tipoVehiculo)
        {
            IVehiculo resultado;

            switch (tipoVehiculo)
            {
                case "Moto":
                    resultado = new Moto() { Nombre = "Moto", Puertas = 0, Ruedas = 2, Capacidad = 2 };
                    break;
                case "Carro":
                    resultado = new Carro() { Nombre = "Carro", Puertas = 4, Ruedas = 4, Capacidad = 5 };
                    break;
                case "Bus":
                    resultado = new Bus() { Nombre = "Bus", Puertas = 3, Ruedas = 6, Capacidad = 40 };
                    break;
                default:
                    resultado = null;
                    break;
            }

            return resultado;
        }
    }
}

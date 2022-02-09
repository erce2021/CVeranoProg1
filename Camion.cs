using System;
using System.Collections.Generic;
using System.Text;

namespace PagodePeaje
{
    class Camion : Vehiculo
    {
        public override void mostrarTipoVehiculo()
        {
            Console.WriteLine("Soy un Camion");
            Console.WriteLine("Cobrar peaje Camion ");
        }
    }
}

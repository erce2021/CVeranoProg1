using System;
using System.Collections.Generic;
using System.Text;

namespace PagodePeaje
{
    class Auto : Vehiculo
    {
        public override void mostrarTipoVehiculo()
        {
            Console.WriteLine("Soy un auto");
            Console.WriteLine("Cobrar peaje auto ");
        }

    }
}

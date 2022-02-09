using System;
using System.Collections.Generic;
using System.Text;

namespace PagodePeaje
{
    class Bus : Vehiculo
    {
        public override void mostrarTipoVehiculo()
        {
            Console.WriteLine("Soy un bus");
            Console.WriteLine("Cobrar peaje bus ");
        }
    }
}

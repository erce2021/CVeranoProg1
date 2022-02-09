using System;
using System.Collections.Generic;
using System.Text;

namespace PagodePeaje
{
    class Moto : Vehiculo
    { 
        public override void mostrarTipoVehiculo()
        {
            Console.WriteLine("Soy una moto");
            Console.WriteLine("Cobrar peaje moto ");
        }
    }
}

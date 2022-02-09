using System;

namespace PagodePeaje
{
    class Test
    {
        

        static void Main(string[] args)
        {
            Auto a = new Auto();
            Moto moto = new Moto();
            Bus bus = new Bus();
            Camion camion = new Camion();

            Peaje peaje = new Peaje();
            peaje.cobrarPeajeAuto(a);
            Console.WriteLine();

            peaje.cobrarPeajeBus(bus);
            Console.WriteLine();

            peaje.cobrarPeajeCamion(camion);
            Console.WriteLine();

            peaje.cobrarPeajeMoto(moto);
            Console.WriteLine();

        }
    }
}

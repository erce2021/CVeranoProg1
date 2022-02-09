using System;
using System.Collections.Generic;
using System.Text;

namespace PagodePeaje
{
    class Peaje
    {
        public void cobrarPeajeMoto(Moto moto)
        {
            moto.mostrarTipoVehiculo();
        }
        public void cobrarPeajeBus(Bus bus)
        {
            bus.mostrarTipoVehiculo();
        }
        public void cobrarPeajeAuto(Auto auto)
        {
            auto.mostrarTipoVehiculo();
        }
        public void cobrarPeajeCamion(Camion camion)
        {
            camion.mostrarTipoVehiculo();
        }
    }
}

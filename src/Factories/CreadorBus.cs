using System;
using ProyectoSistemaReservas.Models;

namespace ProyectoSistemaReservas.Factories
{
    public class CreadorBus : CreadorVehiculo
    {
        public override Vehiculo CrearVehiculo()
        {
            return new Bus();
        }
    }
}

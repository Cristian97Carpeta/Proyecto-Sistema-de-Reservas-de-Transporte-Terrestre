using System;
using ProyectoSistemaReservas.Models;

namespace ProyectoSistemaReservas.Factories
{
    public class CreadorMicrobus : CreadorVehiculo
    {
        public override Vehiculo CrearVehiculo()
        {
            return new Microbus();
        }
    }
}

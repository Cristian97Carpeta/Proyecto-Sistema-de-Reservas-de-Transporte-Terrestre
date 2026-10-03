using System;
using ProyectoSistemaReservas.Models;

namespace ProyectoSistemaReservas.Factories
{
    public abstract class CreadorVehiculo
    {
        // Método fábrica que devuelve un Vehiculo
        public abstract Vehiculo CrearVehiculo();
    }
}

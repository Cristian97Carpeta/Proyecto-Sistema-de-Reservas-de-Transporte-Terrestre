using System;

namespace ProyectoSistemaReservas.Models
{
    public class Bus : Vehiculo
    {
        public Bus()
        {
            Nombre = "Bus";
            Capacidad = 40;
            PrecioBase = 150.00m;
        }
    }
}

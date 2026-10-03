using System;

namespace ProyectoSistemaReservas.Models
{
    public class Microbus : Vehiculo
    {
        public Microbus()
        {
            Nombre = "Microbus";
            Capacidad = 20;
            PrecioBase = 90.00m;
        }
    }
}

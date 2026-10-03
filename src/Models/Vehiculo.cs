using System;

namespace ProyectoSistemaReservas.Models
{
    public abstract class Vehiculo
    {
        public string Nombre { get; protected set; }
        public int Capacidad { get; protected set; }
        public decimal PrecioBase { get; protected set; }

        public Vehiculo()
        {
        }

        public virtual string ObtenerInfo()
        {
            return $"{Nombre} - Capacidad: {Capacidad} pasajeros - Precio base: {PrecioBase:C}";
        }
    }
}

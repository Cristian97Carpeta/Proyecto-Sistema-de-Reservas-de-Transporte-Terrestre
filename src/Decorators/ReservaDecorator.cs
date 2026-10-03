namespace ProyectoSistemaReservas.Decorators;

public abstract class ReservaDecorator : IReserva
{
    protected IReserva Reserva { get; }

    protected ReservaDecorator(IReserva reserva)
    {
        Reserva = reserva;
    }

    public virtual string ObtenerDescripcion()
    {
        return Reserva.ObtenerDescripcion();
    }

    public virtual decimal ObtenerPrecio()
    {
        return Reserva.ObtenerPrecio();
    }
}

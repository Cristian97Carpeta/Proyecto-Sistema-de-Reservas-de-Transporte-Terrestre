namespace ProyectoSistemaReservas.Decorators;

public class DecoradorSeguro : ReservaDecorator
{
    public DecoradorSeguro(IReserva reserva) : base(reserva)
    {
    }

    public override string ObtenerDescripcion()
    {
        return base.ObtenerDescripcion() + " + Seguro de viaje";
    }

    public override decimal ObtenerPrecio()
    {
        return base.ObtenerPrecio() + 20.00m;
    }
}

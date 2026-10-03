namespace ProyectoSistemaReservas.Decorators;

public class DecoradorEquipaje : ReservaDecorator
{
    public DecoradorEquipaje(IReserva reserva) : base(reserva)
    {
    }

    public override string ObtenerDescripcion()
    {
        return base.ObtenerDescripcion() + " + Equipaje adicional";
    }

    public override decimal ObtenerPrecio()
    {
        return base.ObtenerPrecio() + 30.00m;
    }
}

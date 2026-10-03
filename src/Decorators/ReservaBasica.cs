namespace ProyectoSistemaReservas.Decorators;

public class ReservaBasica : IReserva
{
    public string ObtenerDescripcion()
    {
        return "Reserva básica";
    }

    public decimal ObtenerPrecio()
    {
        return 150.00m;
    }
}

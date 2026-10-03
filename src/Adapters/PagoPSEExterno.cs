namespace ProyectoSistemaReservas.Adapters;

public class PagoPSEExterno
{
    public bool RealizarTransaccion(decimal valor)
    {
        Console.WriteLine($"Procesando pago PSE por {valor:C}.");
        return true;
    }
}

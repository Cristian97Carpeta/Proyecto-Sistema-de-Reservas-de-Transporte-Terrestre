namespace ProyectoSistemaReservas.Adapters;

public class AdaptadorPSE : IPago
{
    private readonly PagoPSEExterno _pagoPSEExterno;

    public AdaptadorPSE(PagoPSEExterno pagoPSEExterno)
    {
        _pagoPSEExterno = pagoPSEExterno;
    }

    public bool ProcesarPago(decimal monto)
    {
        return _pagoPSEExterno.RealizarTransaccion(monto);
    }
}

using ProyectoSistemaReservas.Adapters;
using ProyectoSistemaReservas.Decorators;
using ProyectoSistemaReservas.Factories;
using ProyectoSistemaReservas.Models;

namespace ProyectoSistemaReservas.Facade
{
    public class SistemaReservasFacade
    {
        public void RealizarReserva(
            bool usarBus,
            bool agregarEquipaje,
            bool agregarSeguro,
            decimal montoPago)
        {
            // 1. Crear el vehículo utilizando Factory Method
            CreadorVehiculo creador;

            if (usarBus)
            {
                creador = new CreadorBus();
            }
            else
            {
                creador = new CreadorMicrobus();
            }

            Vehiculo vehiculo = creador.CrearVehiculo();

            Console.WriteLine("=== VEHÍCULO ===");
            Console.WriteLine(vehiculo.ObtenerInfo());

            // 2. Crear la reserva básica
            IReserva reserva = new ReservaBasica();

            // 3. Agregar extras utilizando Decorator
            if (agregarEquipaje)
            {
                reserva = new DecoradorEquipaje(reserva);
            }

            if (agregarSeguro)
            {
                reserva = new DecoradorSeguro(reserva);
            }

            Console.WriteLine();
            Console.WriteLine("=== RESERVA ===");
            Console.WriteLine($"Descripción: {reserva.ObtenerDescripcion()}");
            Console.WriteLine($"Precio: {reserva.ObtenerPrecio():C}");

            // 4. Procesar el pago utilizando Adapter
            PagoPSEExterno pagoExterno = new PagoPSEExterno();
            IPago pago = new AdaptadorPSE(pagoExterno);

            bool pagoExitoso = pago.ProcesarPago(montoPago);

            Console.WriteLine();
            Console.WriteLine("=== PAGO ===");

            if (pagoExitoso)
            {
                Console.WriteLine("Pago realizado correctamente.");
            }
            else
            {
                Console.WriteLine("El pago no pudo realizarse.");
            }
        }
    }
}


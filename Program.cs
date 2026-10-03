using ProyectoSistemaReservas.Facade;

SistemaReservasFacade sistema = new SistemaReservasFacade();

Console.WriteLine("=== SISTEMA DE RESERVAS DE TRANSPORTE ===");
Console.WriteLine();

sistema.RealizarReserva(
    true,
    true,
    true,
    200.00m
);

Console.WriteLine();
Console.WriteLine("=== PRUEBA FINALIZADA ===");
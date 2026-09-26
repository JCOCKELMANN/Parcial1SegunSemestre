using SistemaNotificaciones.Models;

List<Notificacion> notificaciones = new()
{
    new CorreoElectronico
    {
        DireccionCorreo = "estudiante@example.com",
        Mensaje = "Tu inscripción se completó correctamente."
    },
    new Sms
    {
        NumeroTelefono = "+502 0000 0000",
        Mensaje = "Recuerda revisar tu horario de clases."
    }
};

Console.WriteLine("SISTEMA DE NOTIFICACIONES (SIMULACIÓN)\n");

foreach (Notificacion notificacion in notificaciones)
{
    // Una misma llamada ejecuta la versión de CorreoElectronico o de Sms.
    notificacion.Enviar();
    Console.WriteLine();
}

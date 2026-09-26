namespace SistemaNotificaciones.Models;

public class Sms : Notificacion
{
    public string NumeroTelefono { get; set; } = string.Empty;

    public override void Enviar()
    {
        Console.WriteLine($"SMS para: {NumeroTelefono}");
        Console.WriteLine($"Mensaje: {Mensaje}");
    }
}

namespace SistemaNotificaciones.Models;

public class CorreoElectronico : Notificacion
{
    public string DireccionCorreo { get; set; } = string.Empty;

    public override void Enviar()
    {
        Console.WriteLine($"Correo electrónico para: {DireccionCorreo}");
        Console.WriteLine($"Mensaje: {Mensaje}");
    }
}

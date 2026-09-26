namespace SistemaNotificaciones.Models;

public abstract class Notificacion
{
    public string Mensaje { get; set; } = string.Empty;

    public abstract void Enviar();
}

namespace RendimientoBancario.Models;

public abstract class CuentaBancaria
{
    public decimal Saldo { get; set; }

    public abstract decimal CalcularInteresMensual();
}

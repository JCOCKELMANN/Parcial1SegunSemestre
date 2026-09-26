namespace RendimientoBancario.Models;

public class CuentaAhorros : CuentaBancaria
{
    // Tasa mensual en forma decimal: 0.01 equivale al 1 %.
    public decimal TasaPromocional { get; set; }

    public override decimal CalcularInteresMensual()
    {
        return Saldo * TasaPromocional;
    }
}

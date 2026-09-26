namespace RendimientoBancario.Models;

public class CuentaInversion : CuentaBancaria
{
    public double FactorRiesgo { get; set; }

    public override decimal CalcularInteresMensual()
    {
        // Supuesto del ejemplo: tasa mensual base del 1 %.
        // El factor se asigna según el saldo al crear la cuenta.
        const decimal tasaBaseMensual = 0.01m;
        return Saldo * tasaBaseMensual * (decimal)FactorRiesgo;
    }
}

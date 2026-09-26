using RendimientoBancario.Models;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

// Reglas ilustrativas, pues el enunciado no especifica tasas ni tramos:
// ahorro: 1 % mensual; inversión: 1 % base multiplicado por el factor.
// Factor de inversión: 1.5 para saldos menores a 10000, 2.0 desde 10000.
decimal saldoInversion = 15000m;

List<CuentaBancaria> cuentas = new()
{
    new CuentaAhorros { Saldo = 5000m, TasaPromocional = 0.01m },
    new CuentaInversion
    {
        Saldo = saldoInversion,
        FactorRiesgo = saldoInversion >= 10000m ? 2.0 : 1.5
    }
};

Console.WriteLine("LIQUIDACIÓN MENSUAL DE INTERESES");

foreach (CuentaBancaria cuenta in cuentas)
{
    decimal saldoAnterior = cuenta.Saldo;
    // La implementación ejecutada depende del tipo real de la cuenta.
    decimal interes = cuenta.CalcularInteresMensual();
    cuenta.Saldo += interes;

    Console.WriteLine($"\n{cuenta.GetType().Name}");
    Console.WriteLine($"Saldo anterior: {saldoAnterior:F2}");
    Console.WriteLine($"Interés abonado: {interes:F2}");
    Console.WriteLine($"Saldo final: {cuenta.Saldo:F2}");
}

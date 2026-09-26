# Parcial 1: herencia y polimorfismo en C#

Dos aplicaciones de consola independientes. Requieren el SDK de .NET 10.

## Ejercicio 1: rendimiento bancario

```powershell
dotnet run --project RendimientoBancario
```

`CuentaBancaria` define `Saldo` y el método abstracto `CalcularInteresMensual()`. `CuentaAhorros` y `CuentaInversion` heredan de ella y sobrescriben ese método con `override`. Se conservan los tipos del diagrama: `decimal` para importes y tasa promocional, `double` para el factor de riesgo.

El enunciado no proporciona fórmulas, tasas ni límites de saldo. Se adoptan estos supuestos únicamente para demostrar el funcionamiento:

- Ahorros: interés = saldo × tasa promocional mensual. El ejemplo usa 0.01 (1 %).
- Inversión: interés = saldo × 0.01 × factor de riesgo. El programa asigna un factor de 1.5 si el saldo inicial es menor a 10000 y de 2.0 desde 10000.
- Los valores son ilustrativos y no representan condiciones bancarias reales.

El programa recorre una `List<CuentaBancaria>`, calcula los intereses mediante polimorfismo y los abona al saldo. En ahorros se obtiene un interés de 50.00 y un saldo final de 5050.00; en inversión, un interés de 300.00 y un saldo final de 15300.00. Se demuestra una liquidación mensual; para simular más meses debe actualizarse el factor de inversión según el saldo de cada período.

## Ejercicio 2: notificaciones

```powershell
dotnet run --project SistemaNotificaciones
```

La distribución de archivos sigue el enunciado:

```text
SistemaNotificaciones/
├── Models/
│   ├── CorreoElectronico.cs
│   ├── Notificacion.cs
│   └── Sms.cs
├── Program.cs
└── SistemaNotificaciones.csproj
```

`Notificacion` declara `Mensaje` y el método abstracto `Enviar()`. `CorreoElectronico` agrega `DireccionCorreo` y `Sms` agrega `NumeroTelefono`. Ambas clases implementan `Enviar()` con `override`.

Una `List<Notificacion>` contiene ambos tipos. Al llamar a `Enviar()` en el ciclo, C# ejecuta la implementación del objeto concreto. Los envíos se simulan mostrando el destinatario y el mensaje en consola.

En ambos ejercicios se eligieron clases base abstractas para exigir una implementación en cada clase derivada. Los atributos públicos del diagrama se representan mediante propiedades públicas de C#.

// EJERCICIO 10
// Sistema de registro y monitoreo de un motor
//
// CLASE:
// Motor
//
// OBJETO:
// motor1
//
// PROPIEDADES:
// -Identificador
// -Temperatura
// -Velocidad
//
// MÉTODOS:
// MostrarDatos()
// VerificarTemperatura()



Console.WriteLine("SISTEMA DE MONITOREO DE MOTOR");
Console.WriteLine();

Motor motor1 = new Motor();

Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin identificador";

Console.Write("Ingrese la temperatura del motor (°C): ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad del motor (RPM): ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
motor1.MostrarDatos();

Console.WriteLine($"Estado de temperatura: {motor1.VerificarTemperatura()}");

class Motor
{
  
    public string Identificador { get; set; } = "";

    public double Temperatura { get; set; }

    public double Velocidad { get; set; }

    public void MostrarDatos()
    {
        Console.WriteLine($"Identificador: {Identificador}");
        Console.WriteLine($"Temperatura: {Temperatura} °C");
        Console.WriteLine($"Velocidad: {Velocidad} RPM");
    }

    public string VerificarTemperatura()
    {
        if (Temperatura > 70)
        {
            return "TEMPERATURA MAYOR A 70 °C";
        }
        else
        {
            return "TEMPERATURA NORMAL";
        }
    }
}
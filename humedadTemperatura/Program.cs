using System;

namespace HumedadTemperatura
{
    public interface ISensor
    {
        double Leer();
    }

    public class SensorTemperatura : ISensor
    {
        public double Leer()
        {
            // Simulación de lectura de temperatura
            Random random = new Random();
            return random.Next(-10, 40); // Retorna una temperatura aleatoria entre -10 y 40 grados Celsius
        }
    }

    public class SensorHumedad : ISensor
    {
        public double Leer()
        {
            // Simulación de lectura de humedad
            Random random = new Random();
            return random.Next(0, 100); // Retorna un porcentaje de humedad aleatorio entre 0 y 100
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ISensor sensorTemperatura = new SensorTemperatura();
            ISensor sensorHumedad = new SensorHumedad();

            Console.WriteLine($"Temperatura: {sensorTemperatura.Leer()} °C");
            Console.WriteLine($"Humedad: {sensorHumedad.Leer()} %");
        }
    }
}
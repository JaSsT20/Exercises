using System;

namespace Exercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintMyName();
            Console.WriteLine("---------------------------");
            CalculatePolygonArea(5, 13.12f);
            Console.WriteLine("---------------------------");
            DegreesToRadians(1);
            Console.WriteLine("---------------------------");
            CentigradesToFahrenheit(0);
            Console.WriteLine("---------------------------");
            DolarToEuro(1);
        }

        public static void PrintMyName()
        {
            //1 Cree un proyecto nuevo que imprima su nombre en la ventana de la consola.
            Console.WriteLine("Hola, Levid.");
            //5 Agregue más mensajes a la aplicación que ha creado.
            Console.WriteLine("He agregado una linea.");
        }

        //Cap 2 -> Ejercicio 1
        public static void CalculatePolygonArea(int totalSides, float sideLength)
        {
            float perimeter = totalSides * sideLength;
            Console.WriteLine($"Total de lados: {totalSides}");
            Console.WriteLine($"Largo de los lados: {sideLength}");
            Console.WriteLine($"El perímetro es: {perimeter}");
        }

        //Cap 2 -> Ejercicio 3
        public static void DegreesToRadians(float degreesToConvert)
        {
            const float PI = 3.1416f;
            float radians = (degreesToConvert * PI/180);
            Console.WriteLine($"Grados a convertir: {degreesToConvert}");
            Console.WriteLine($"Total radianes: {radians}");
        }
        //Cap 2 -> Ejercicio 4
        public static void CentigradesToFahrenheit(float centigradesToConvert)
        {
            float fahrenheit = (centigradesToConvert * 9/5) + 32;
            Console.WriteLine($"Grados centígrados a convertir: {centigradesToConvert}°C");
            Console.WriteLine($"Total fahrenheit: {fahrenheit}°F");
        }
        //Cap 2 -> Ejercicio 5
        public static void DolarToEuro(float dolarToConvert)
        {
            float euros = 0.92f, totalEuros = dolarToConvert * euros;
            Console.WriteLine($"Dólares a convertir: ${dolarToConvert}");
            Console.WriteLine($"Total euros: €{totalEuros}");
        }
    }
}
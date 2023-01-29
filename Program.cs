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
            Console.WriteLine("---------------------------");
            EvenOrOdd();
            Console.WriteLine("---------------------------");
            DayOfTheWeek();
            Console.ReadLine();
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

        //Cap 3 -> Ejercicio 1
        public static void EvenOrOdd()
        {
            Console.WriteLine("Introduzca un número: ");
            int number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
                Console.WriteLine($"{number} es par.");
            else
                Console.WriteLine($"{number} es impar.");
        }
        //Cap 3 -> Ejercicio 4
        public static void DayOfTheWeek()
        {
            System.Console.WriteLine("Introduzca un número del 1-7: ");
            int option = int.Parse(Console.ReadLine());
            
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine("Domingo.");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Lunes.");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Martes.");
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Miércoles.");
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Jueves.");
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Viernes.");
                    break;
                }
                case 7:
                {
                    Console.WriteLine("Sábado.");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Número inválido.");
                    break;
                }
            }
        }
    }
}
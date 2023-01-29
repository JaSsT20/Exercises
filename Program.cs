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

        }

        public static void PrintMyName()
        {
            //1 Cree un proyecto nuevo que imprima su nombre en la ventana de la consola.
            Console.WriteLine("Hola, Levid.");
            //5 Agregue más mensajes a la aplicación que ha creado.
            Console.WriteLine("He agregado una linea.");
        }

        public static void CalculatePolygonArea(int totalSides, float sideLength)
        {
            float perimeter = totalSides * sideLength;
            Console.WriteLine($"Total de lados: {totalSides}");
            Console.WriteLine($"Largo de los lados: {sideLength}");
            Console.WriteLine($"El perímetro es: {perimeter}");
        }

        public static void DegreesToRadians(float degreesToConvert)
        {
            const float PI = 3.1416f;
            float radians = (degreesToConvert * PI/180);
            System.Console.WriteLine($"Grados a convertir: {degreesToConvert}");
            System.Console.WriteLine($"Total radianes: {radians}");
        }
    }
}
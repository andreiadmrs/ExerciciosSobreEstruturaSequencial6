using System;
using System.Globalization;

namespace ExerciciosSobreEstruturaSequencial6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.*/

            double pi = 3.14159;

            Console.WriteLine("Digite um número: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um número: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um número: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = pi * (c * c);
            double areaTrapezio = ((b + a) * c )/ 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine("Triangulo: " + areaTriangulo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: " + areaCirculo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + areaTrapezio.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + areaQuadrado.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Rentangulo: " + areaRetangulo.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

using System;
using System.Globalization;


namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;

            Console.WriteLine("Digite três números separados por espaço (A B C):");
            if (valores.Length < 3) {
                Console.WriteLine("Erro: você precisa digitar três valores.");
                return;
            }

            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            TRIANGULO = A * C / 2.0;
            CIRCULO = 3.14159 * C * C;
            TRAPEZIO = (A + B) / 2.0 * C;
            QUADRADO = B * B;
            RETANGULO = A * B;


            Console.WriteLine($"Triangulo: {TRIANGULO.ToString("F3")}");
            Console.WriteLine($"Círculo: {CIRCULO.ToString("F3")}");
            Console.WriteLine($"Trapézio: {TRAPEZIO.ToString("F3")}");
            Console.WriteLine($"Quadrado: {QUADRADO.ToString("F3")}");
            Console.WriteLine($"Retângulo: {RETANGULO.ToString("F3")}");
        }
    }
}

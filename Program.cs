using System;

class Program
{
    static void Main()
    {
        // Exemplos de entrada
        TestaEquacao(0, 2, 5);   // Não é equação do 2º grau
        TestaEquacao(1, 2, 3);   // Delta < 0, sem raízes reais
        TestaEquacao(1, 2, -3);  // Delta > 0, raízes reais corretas
    }

    static void TestaEquacao(double a, double b, double c)
    {
        Console.WriteLine("\n-- Equação do segundo grau --");
        Console.WriteLine($"(a): {a}");
        Console.WriteLine($"(b): {b}");
        Console.WriteLine($"(c): {c}");

        if (a == 0)
        {
            Console.WriteLine("Não é uma equação de segundo grau!");
            return;
        }

        double delta = (b * b) - (4 * a * c);
        Console.WriteLine($"Delta = {delta:F2}");

        if (delta < 0)
        {
            Console.WriteLine("Como delta < 0, a equação não possui raízes reais!");
        }
        else
        {
            double raiz = Math.Sqrt(delta);
            double x1 = (-b + raiz) / (2 * a);
            double x2 = (-b - raiz) / (2 * a);

            Console.WriteLine($"x1 = {x1:F2} e x2 = {x2:F2}");
        }
    }
}
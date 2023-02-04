using System;

namespace QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rownanie kwadratowe: ax^2 + bx + c = 0");
            Console.WriteLine("Wpisz a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz c:");
            double c = double.Parse(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Roots are real and different.");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Roots are real and same.");
                Console.WriteLine("x1 = x2 = " + x);
            }
            else
            {
                Console.WriteLine("Roots are complex and different.");
            }
            Console.ReadLine();
        }
    }
}



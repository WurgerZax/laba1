using System;
namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Квадрат от разницы двух чисел
            Console.WriteLine("\n\n Code Solution\n\n");
            double a;
            double b;
            double result=0;
            Double.TryParse(Console.ReadLine(), out a);
            Double.TryParse(Console.ReadLine(), out b);
            result = Math.Pow((a - b), 2);
            Console.WriteLine("Your result is: " + result);
        }
    }
}

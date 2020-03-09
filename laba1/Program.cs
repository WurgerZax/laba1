using System;
namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            //question number = (n*k) % 24 + 1,
            //где порядковый номер вопроса n = 1..5, k - номер по списку
            double question = 0;
            int n = 1;
            double k = 15;
            for (n = 1; n <= 5; n++) 
            {
                question = (n * k) % 24 + 1;
                Console.WriteLine("N= "+ n);
                Console.WriteLine("Question= "+ question);
            }
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

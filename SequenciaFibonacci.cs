using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            if (VerifyFibonacci(number))
            {
                Console.WriteLine("O número " + number + " pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("O número " + number + " não pertence à sequência de Fibonacci.");
            }
            Console.ReadLine();
        }

        static bool VerifyFibonacci(int num, int a = 0, int b = 1)
        {
            if (num == a) 
            {
                return true;
            }
            else if (num < a)
            {
                return false;
            }
            return VerifyFibonacci(num, b, a + b);
        }
    }
}

using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual número inteiro você gostaria de saber se faz parte da sequência de Fibonacci?");
            int number = int.Parse(Console.ReadLine());

            int previousNumber = 0;
            int currentNumber = 1;
            int newNumber = previousNumber + currentNumber;
            while (newNumber <= number)
            {
                previousNumber = currentNumber;
                currentNumber = newNumber;
                newNumber = previousNumber + currentNumber; 
            }

            if (number == 0 || number == 1 || number == newNumber || number == currentNumber)
            {
                Console.WriteLine($"O número {number} faz parte da sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {number} não faz parte da sequência de Fibonacci.");
            }
            Console.ReadLine();
        }
    }
}
